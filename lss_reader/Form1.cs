using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace lss_reader
{
	public partial class Form1 : Form
	{
		int PrevWidth, PrevHeight;
		LssContainer container;
		List<LssElements> tag_components;
		BackgroundWorker worker;
		public Form1()
		{
			InitializeComponent();
			PrevWidth = Size.Width;
			PrevHeight = Size.Height;
			tag_components = new List<LssElements>();

			worker = new BackgroundWorker();
			worker.WorkerReportsProgress = true;
			worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(AddLssComponentsComplete);
			worker.DoWork += new DoWorkEventHandler(AddLssComponents);
			worker.ProgressChanged += new ProgressChangedEventHandler(UpdateProgressBar);
		}

		private void btnOpenFile_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.DefaultExt = "*.lss";
			dialog.Filter = "LSS File|*.lss|ALL File|*.*";
			
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				pbProgress.Visible = true;
				tbFileName.Text = dialog.FileName;
				worker.RunWorkerAsync(container);
			}
		}

		private void AddLssComponents(object obj, DoWorkEventArgs arg)
		{
			LssContainer lss = (LssContainer)arg.Argument;
			container = new LssContainer(tbFileName.Text, new LssContainer.UpdateProgress(worker.ReportProgress));
		}

		public void UpdateProgressBar(object obj, ProgressChangedEventArgs arg)
		{
			pbProgress.Value = arg.ProgressPercentage;
		}
		public void AddLssComponentsComplete(object obj, RunWorkerCompletedEventArgs arg)
		{
			lbLssFile.DataSource = null;
			lbLssFile.DataSource = container.TagList;
			lbLssFile.DisplayMember = "Tag";
			pbProgress.Visible = false;
			MessageBox.Show("Load Completed!");
		}

		private void testSplit()
		{
			string text = "  400164:	4b08      	ldr	r3, [pc, #32]	; (400188 <frame_dummy+0x24>)";
			string text2 = "20400080 <NdefHeader>:";
			string text3 = "  40007c:	0040b625 	.word	0x0040b625";
			string[] cmt = text.Split(new char[] { ';' });
			string[] cmd = cmt[0].Split(new char[] { ':' });
			string[] sings = cmd[0].Split(new char[] { '<', '>' });
			string[] str = cmd[1].Split(new char[] { '\t' });

			for (int cnt = 0; cnt < cmt.Length; cnt++)
			{
				rtbText.AppendText(cmt[cnt]);
				rtbText.AppendText("\r\n");
			}
			rtbText.AppendText("\r\n");
			rtbText.AppendText("-----------------");
			rtbText.AppendText("\r\n");
			for (int cnt = 0; cnt < cmd.Length; cnt++)
			{
				rtbText.AppendText(cmd[cnt]);
				rtbText.AppendText("\r\n");
			}
			rtbText.AppendText("\r\n");
			rtbText.AppendText("-----------------");
			rtbText.AppendText("\r\n");
			for (int cnt = 0; cnt < sings.Length; cnt++)
			{
				rtbText.AppendText(sings[cnt]);
				rtbText.AppendText("\r\n");
			}
			rtbText.AppendText("\r\n");
			rtbText.AppendText("-----------------");
			rtbText.AppendText("\r\n");
			for (int cnt = 0; cnt < str.Length; cnt++)
			{
				rtbText.AppendText(str[cnt]);
				rtbText.AppendText("\r\n");
			}
		}

		private void lbLssFile_SelectedIndexChanged(object sender, EventArgs e)
		{
			lbLssElement_SelectedItemChanged();
		}

		private void lbComponents_SelectedIndexChanged(object sender, EventArgs e)
		{
			LssElements element = (LssElements)lbComponents.SelectedItem;

			if(element != null)
			{
				tbStringLine.Text = element.StringLine;
				tbMemory.Text = "0x" + element.Memory;
				tbTag.Text = element.Tag;
				tbParameter.Text = element.Parameter;
				tbInstruction.Text = element.Instruction;
				tbHexInstruction.Text = element.HexInstruction;
				tbComment.Text = element.CommentValue;

				rtbText.Focus();
				rtbText.Find(element.StringLine, RichTextBoxFinds.MatchCase);
			}
		}

		private void tbSearch_TextChanged(object sender, EventArgs e)
		{
			int index = lbLssFile.FindString(tbSearch.Text);
			lbLssFile.SelectedIndex = index;
		}

		private void cbComment_CheckedChanged(object sender, EventArgs e)
		{
			lbLssElement_SelectedItemChanged();
		}

		private void lbLssElement_SelectedItemChanged()
		{
			LssElements element = (LssElements)lbLssFile.SelectedItem;
			if (element != null)
			{
				int StartIndex = container.ElementList.FindIndex(x => x.Memory.Equals(element.Memory));
				int EndIndex;
				if (lbLssFile.SelectedIndex != lbLssFile.Items.Count - 1)
				{
					LssElements next_element = (LssElements)lbLssFile.Items[lbLssFile.SelectedIndex + 1];
					EndIndex = container.ElementList.FindIndex(x => x.Memory.Equals(next_element.Memory));
				}
				else
				{
					EndIndex = container.ElementList.Count;
				}
				rtbText.Clear();
				tag_components.Clear();
				for (int cnt = StartIndex; cnt < EndIndex; cnt++)
				{
					LssElements item = container.ElementList[cnt];
					if(item.ElementType == LssElements.LssType.CSOURCE)
					{
						rtbText.SelectionColor = Color.Black;
						if (cbComment.Checked == true)
						{
							tag_components.Add(item);
						}
					}
					else
					{
						rtbText.SelectionColor = Color.Red;
						tag_components.Add(item);
					}
					rtbText.AppendText(item.StringLine);
					rtbText.AppendText("\r\n");
				}
				lbComponents.DataSource = null;
				lbComponents.DataSource = tag_components;
				lbComponents.DisplayMember = "Memory";
				lbComponents.SelectedItem = null;
			}
		}

		private void Form1_SizeChanged(object sender, EventArgs e)
		{
			if (Size.Width <= 695)
				Size = new Size(695, Size.Height);
			if (Size.Height <= 553)
				Size = new Size(Size.Width, 553);

			if (PrevWidth != Size.Width)
			{
				int DiffW = Size.Width - PrevWidth;
				PrevWidth = Size.Width;
				gbElement.Location = new Point(Size.Width / 2 - gbElement.Size.Width / 2,
												Size.Height - 206);


				lbLssFile.Location = new Point(lbLssFile.Location.X + DiffW, lbLssFile.Location.Y);
				lbComponents.Location = new Point(lbComponents.Location.X + DiffW, 
											lbComponents.Location.Y);
				cbComment.Location = new Point(cbComment.Location.X + DiffW, cbComment.Location.Y);
				tbSearch.Location = new Point(tbSearch.Location.X + DiffW, tbSearch.Location.Y);
				btnOpenFile.Location = new Point(btnOpenFile.Location.X + DiffW, btnOpenFile.Location.Y);

				pbProgress.Size = new Size(pbProgress.Size.Width + DiffW, pbProgress.Size.Height);
				tbFileName.Size = new Size(tbFileName.Size.Width + DiffW, tbFileName.Size.Height);
				rtbText.Size = new Size(rtbText.Size.Width + DiffW, rtbText.Size.Height);
			}
			if (PrevHeight != Size.Height)
			{
				int DiffH = Size.Height - PrevHeight;
				PrevHeight = Size.Height;
				gbElement.Location = new Point(Size.Width / 2 - gbElement.Size.Width / 2,
												Size.Height - 206);
				lbComponents.Location = new Point(lbComponents.Location.X,
											lbComponents.Location.Y + DiffH);
				lbLssFile.Size = new Size(lbLssFile.Size.Width, lbLssFile.Size.Height + DiffH);
				rtbText.Size = new Size(rtbText.Size.Width, rtbText.Size.Height + DiffH);
			}

		}
	}
}
