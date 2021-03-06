﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using HyoutaUtils;

namespace HyoutaTools.Tales.Vesperia.WRLDDAT {
	public class WRLDDAT {
		public WRLDDAT( String filename, EndianUtils.Endianness endian ) {
			using ( Stream stream = new System.IO.FileStream( filename, FileMode.Open ) ) {
				if ( !LoadFile( stream, endian ) ) {
					throw new Exception( "Loading WRLDDAT failed!" );
				}
			}
		}

		public WRLDDAT( Stream stream, EndianUtils.Endianness endian ) {
			if ( !LoadFile( stream, endian ) ) {
				throw new Exception( "Loading WRLDDAT failed!" );
			}
		}

		public List<Location> LocationList;
		public Dictionary<uint, Location> LocationIdDict;

		private bool LoadFile( Stream stream, EndianUtils.Endianness endian ) {
			string magic = stream.ReadAscii( 8 );
			if ( magic != "WRLDDAT\0" ) {
				throw new Exception( "Invalid magic." );
			}
			uint unknown = stream.ReadUInt32().FromEndian( endian );
			uint locationCount = stream.ReadUInt32().FromEndian( endian );

			LocationList = new List<Location>( (int)locationCount );
			for ( uint i = 0; i < locationCount; ++i ) {
				Location l = new Location( stream, endian );
				LocationList.Add( l );
			}

			LocationIdDict = new Dictionary<uint, Location>( LocationList.Count );
			foreach ( Location l in LocationList ) {
				LocationIdDict.Add( l.LocationID, l );
			}

			return true;
		}
	}
}
