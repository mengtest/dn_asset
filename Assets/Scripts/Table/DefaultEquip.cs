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
    
    
    public class DefaultEquip : CVSReader {
        
        public class RowData{
			public uint ProfID;
			public string ProfName;
			public string Face;
			public string Hair;
			public string Helmet;
			public string Body;
			public string Leg;
			public string Glove;
			public string Boots;
			public string Weapon;
			public string SecondWeapon;
			public string Wing;
			public string Tail;
			public string Decal;
			public string WeaponPoint;
			public string SecondWeaponPoint;
			public string WingPoint;
			public string TailPoint;
			public string FishingPoint;
			public string SideWeaponPoint;
		}


		private static DefaultEquip s = null;

		public static DefaultEquip sington
		{
			get { if (s == null) { s = new DefaultEquip(); s.Create(); } return s; }
		}

		public RowData[] Table { get { return table; } }

		private RowData[] table = null;

		public override string bytePath { get { return "Table/DefaultEquip"; } }
        
        public override void OnClear(int lineCount) {
			if (lineCount > 0) table = new RowData[lineCount];
			else table = null;
        }
        
        public override void ReadLine(System.IO.BinaryReader reader) {
			RowData row = new RowData();
			Read<uint>(reader, ref row.ProfID, uintParse); columnno = 0;
			Read<string>(reader, ref row.ProfName, stringParse); columnno = 1;
			Read<string>(reader, ref row.Face, stringParse); columnno = 2;
			Read<string>(reader, ref row.Hair, stringParse); columnno = 3;
			Read<string>(reader, ref row.Helmet, stringParse); columnno = 4;
			Read<string>(reader, ref row.Body, stringParse); columnno = 5;
			Read<string>(reader, ref row.Leg, stringParse); columnno = 6;
			Read<string>(reader, ref row.Glove, stringParse); columnno = 7;
			Read<string>(reader, ref row.Boots, stringParse); columnno = 8;
			Read<string>(reader, ref row.Weapon, stringParse); columnno = 9;
			Read<string>(reader, ref row.SecondWeapon, stringParse); columnno = 10;
			Read<string>(reader, ref row.Wing, stringParse); columnno = 11;
			Read<string>(reader, ref row.Tail, stringParse); columnno = 12;
			Read<string>(reader, ref row.Decal, stringParse); columnno = 13;
			Read<string>(reader, ref row.WeaponPoint, stringParse); columnno = 14;
			Read<string>(reader, ref row.SecondWeaponPoint, stringParse); columnno = 15;
			Read<string>(reader, ref row.WingPoint, stringParse); columnno = 16;
			Read<string>(reader, ref row.TailPoint, stringParse); columnno = 17;
			Read<string>(reader, ref row.FishingPoint, stringParse); columnno = 18;
			Read<string>(reader, ref row.SideWeaponPoint, stringParse); columnno = 19;
			Table[lineno] = row;
			columnno = -1;
        }
    }
}
