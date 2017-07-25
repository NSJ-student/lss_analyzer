using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace lss_reader
{
	class LssContainer
	{
		public delegate void UpdateProgress(int value);
		public string[] AllStrings;
		public List<LssElements> ElementList;
		public List<LssElements> TagList;
		public LssContainer(string FileName)
		{
			ElementList = new List<LssElements>();
			TagList = new List<LssElements>();
			AllStrings = File.ReadAllLines(FileName);
			for (int cnt=0; cnt<AllStrings.Length; cnt++)
			{
				string str = AllStrings[cnt];
				if (!str.Replace(" ", string.Empty).Equals(""))
				{
					LssElements element = new LssElements(str);
					ElementList.Add(element);
					if(element.Tag != null)
						TagList.Add(element);
				}
			}
		}
		public LssContainer(string FileName, UpdateProgress Update)
		{
			ElementList = new List<LssElements>();
			TagList = new List<LssElements>();
			AllStrings = File.ReadAllLines(FileName);
			for (int cnt = 0; cnt < AllStrings.Length; cnt++)
			{
				string str = AllStrings[cnt];
				if (!str.Replace(" ", string.Empty).Equals(""))
				{
					LssElements element = new LssElements(str);
					ElementList.Add(element);
					if (element.Tag != null)
						TagList.Add(element);
					Update((cnt+1) * 100 / AllStrings.Length);
				}
			}
		}
	}
	class LssElements
	{
		public enum LssType
		{
			TAG_NAME,
			ASSEM_INSTRUCTION,
			CSOURCE,
			WORD_DATA,
			ANYTHING_ELSE
		};
		LssType Type;
		string EntireString;
		uint MemoryPosition;
		string Name;
		string strInstruction;
		string strParameter;
		uint hexInstruction;
		string Comment;

		public LssType ElementType
		{
			get
			{
				return Type;
			}
		}
		public string CommentValue
		{
			get
			{
				return Comment;
			}
		}
		public string Parameter
		{
			get
			{
				return strParameter;
			}
		}
		public string HexInstruction
		{
			get
			{
				return hexInstruction.ToString("X");
			}
		}
		public string Instruction
		{
			get
			{
				return strInstruction;
			}
		}
		public string StringLine
		{
			get
			{
				return EntireString;
			}
		}
		public string Tag
		{
			get
			{
				return Name;
			}
		}
		public string Memory
		{
			get
			{
				return MemoryPosition.ToString("X");
			}
		}

		public LssElements(string strLine)
		{
			EntireString = strLine;
			string[] cmt = strLine.Split(new char[] { ';' });

			Comment = null;

			string[] split1 = cmt[0].Split(new char[] { ':' });
			if (split1.Length == 2)
			{
				if ((split1[0].Length > 9) && (split1[0][9] == '<') && (split1[0][split1[0].Length - 1] == '>'))
				{
					string[] arrstr = strLine.Split(new char[] { '<', '>' });
					Type = LssType.TAG_NAME;
					Name = arrstr[1].Trim();
					MemoryPosition = Convert.ToUInt32(arrstr[0].Trim(), 16);

					hexInstruction = 0;
					strInstruction = null;
					strParameter = null;
					return;
				}
				if ((split1[0].Length == 8) &&
					( ((split1[0][0] == ' ') && (split1[0][1] == ' ')) || (split1[0][0] == '2') ))
				{
					if (cmt.Length == 2)
					{
						Comment = cmt[1];
					}
					Name = null;
					MemoryPosition = Convert.ToUInt32(split1[0].Trim(), 16);

					string[] split2 = split1[1].Split(new char[] { '\t' });
					try
					{
						hexInstruction = Convert.ToUInt32(split2[1].Replace(" ", string.Empty), 16);
						strInstruction = split2[2].Trim();
						if (split2.Length >= 4)
						{
							strParameter = split2[3];
						}
						if (strInstruction.Equals(".word"))
						{
							Type = LssType.WORD_DATA;

						}
						else
						{
							Type = LssType.ASSEM_INSTRUCTION;
						}
					}
					catch
					{
						strParameter = split2[1];
					}
					return;
				}
			}
			Type = LssType.CSOURCE;
			Name = null;
			MemoryPosition = 0;
			hexInstruction = 0;
			strInstruction = strLine;
			strParameter = null;
		}
	}
}
