﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HyoutaTools;
using HyoutaTools.Tales.Vesperia;
using HyoutaTools.Tales.Vesperia.TSS;
using HyoutaUtils;

namespace HyoutaLibGUI.Tales.Vesperia.ItemDat {
	class RunItemViewer {
		public static int Execute( List<string> args ) {
			if ( args.Count < 7 ) {
				Console.WriteLine( "Usage: [360/PS3] ITEM.DAT STRING_DIC.SO T8BTSK T8BTEMST COOKDAT WRLDDAT ITEMSORT.DAT" );
				return -1;
			}

			GameVersion? version = null;
			switch ( args[0].ToUpperInvariant() ) {
				case "360":
					version = GameVersion.X360_EU;
					break;
				case "PS3":
					version = GameVersion.PS3;
					break;
			}

			if ( version == null ) {
				Console.WriteLine( "First parameter must indicate game version!" );
				return -1;
			}

			HyoutaTools.Tales.Vesperia.ItemDat.ItemDat items = new HyoutaTools.Tales.Vesperia.ItemDat.ItemDat( args[1], args[7], EndianUtils.Endianness.BigEndian );

			TSSFile TSS;
			try {
				TSS = new TSSFile( args[2], TextUtils.GameTextEncoding.ShiftJIS, EndianUtils.Endianness.BigEndian );
			} catch ( System.IO.FileNotFoundException ) {
				Console.WriteLine( "Could not open STRING_DIC.SO, exiting." );
				return -1;
			}

			HyoutaTools.Tales.Vesperia.T8BTSK.T8BTSK skills = new HyoutaTools.Tales.Vesperia.T8BTSK.T8BTSK( args[3], EndianUtils.Endianness.BigEndian, BitUtils.Bitness.B32 );
			HyoutaTools.Tales.Vesperia.T8BTEMST.T8BTEMST enemies = new HyoutaTools.Tales.Vesperia.T8BTEMST.T8BTEMST( args[4], EndianUtils.Endianness.BigEndian, BitUtils.Bitness.B32 );
			HyoutaTools.Tales.Vesperia.COOKDAT.COOKDAT cookdat = new HyoutaTools.Tales.Vesperia.COOKDAT.COOKDAT( args[5], EndianUtils.Endianness.BigEndian );
			HyoutaTools.Tales.Vesperia.WRLDDAT.WRLDDAT locations = new HyoutaTools.Tales.Vesperia.WRLDDAT.WRLDDAT( args[6], EndianUtils.Endianness.BigEndian );

			Console.WriteLine( "Initializing GUI..." );
			ItemForm itemForm = new ItemForm( version.Value, items, TSS, skills, enemies, cookdat, locations );
			itemForm.Show();
			return 0;
		}
	}
}
