//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace XTable {
    
    
    public class XNpcList : CVSReader {
        
        public class RowData{
			public int NPCID;
			public string NPCName;
			public uint PresentID;
			public string NPCIcon;
			public string NPCPortrait;
			public int NPCScene;
			public float[] NPCPosition;
			public float[] NPCRotation;
			public int RequiredTaskID;
			public string Content;
			public string FunctionList;
			public int Gazing;
			public bool OnlyHead;
			public string Voice;
			public string ShowUp;
			public int DisappearTask;
			public int NPCType;
		}


		private static XNpcList s = null;

		public static XNpcList sington
		{
			get { if (s == null) { s = new XNpcList(); s.Create(); } return s; }
		}

		public RowData[] Table { get { return table; } }

		private RowData[] table = null;

		public override string bytePath { get { return "Table/XNpcList"; } }
        
        public override void OnClear(int lineCount) {
			if (lineCount > 0) table = new RowData[lineCount];
			else table = null;
        }
        
        public override void ReadLine(System.IO.BinaryReader reader) {
			RowData row = new RowData();
			Read<int>(reader, ref row.NPCID, intParse); columnno = 0;
			Read<string>(reader, ref row.NPCName, stringParse); columnno = 1;
			Read<uint>(reader, ref row.PresentID, uintParse); columnno = 2;
			Read<string>(reader, ref row.NPCIcon, stringParse); columnno = 3;
			Read<string>(reader, ref row.NPCPortrait, stringParse); columnno = 4;
			Read<int>(reader, ref row.NPCScene, intParse); columnno = 5;
			ReadArray<float>(reader, ref row.NPCPosition, floatParse); columnno = 6;
			ReadArray<float>(reader, ref row.NPCRotation, floatParse); columnno = 7;
			Read<int>(reader, ref row.RequiredTaskID, intParse); columnno = 8;
			Read<string>(reader, ref row.Content, stringParse); columnno = 9;
			Read<string>(reader, ref row.FunctionList, stringParse); columnno = 10;
			Read<int>(reader, ref row.Gazing, intParse); columnno = 11;
			Read<bool>(reader, ref row.OnlyHead, boolParse); columnno = 12;
			Read<string>(reader, ref row.Voice, stringParse); columnno = 13;
			Read<string>(reader, ref row.ShowUp, stringParse); columnno = 14;
			Read<int>(reader, ref row.DisappearTask, intParse); columnno = 15;
			Read<int>(reader, ref row.NPCType, intParse); columnno = 16;
			Table[lineno] = row;
			columnno = -1;
        }
    }
}
