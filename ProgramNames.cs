﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HyoutaTools {
	public class ProgramName : IEquatable<string>, IComparable<ProgramName> {
		public string Name;
		public string Shortcut;
		public ProgramName( string Name, string Shortcut ) { this.Name = Name; this.Shortcut = Shortcut; }
		public bool Equals( string other ) { return Name.ToLowerInvariant() == other.ToLowerInvariant() || Shortcut.ToLowerInvariant() == other.ToLowerInvariant(); }
		public int CompareTo( ProgramName other ) { return Name.CompareTo( other.Name ); }
	}

	public class ProgramNames {
		public delegate int ExecuteProgramDelegate( List<string> args );

		internal static List<KeyValuePair<ProgramName, ExecuteProgramDelegate>> BuiltInTools = new List<KeyValuePair<ProgramName, ExecuteProgramDelegate>>() {
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "DanganRonpa.Pak.Extract",                 "DrPakE"      ),  DanganRonpa.Pak.Program.ExecuteExtract) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "DanganRonpa.Pak.Pack",                    "DrPakP"      ),  DanganRonpa.Pak.Program.ExecutePack) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "DanganRonpa.umdimagedat",                 "DrUmdImg"    ),  DanganRonpa.umdimagedat.umdimagedat.Execute) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "Generic.BlockCopy",                       "BlockCopy"   ),  Generic.BlockCopy.BlockCopy.Execute) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "Generic.ByteHotfix",                      "ByteFix"     ),  Generic.ByteHotfix.ByteHotfix.Execute) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "Generic.ByteSwap",                        "ByteSwap"    ),  Generic.ByteSwap.ByteSwap.Execute) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "GraceNote.DanganRonpa.LinImport",         "GNDRlinIm"   ),  GraceNote.DanganRonpa.LinImport.Importer.Import) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "GraceNote.DanganRonpa.LinExport",         "GNDRlinEx"   ),  GraceNote.DanganRonpa.LinExport.Exporter.Export) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "GraceNote.DanganRonpa.NonstopMetaIntoDb", "-"           ),  GraceNote.DanganRonpa.NonstopExistingDatabaseImport.Importer.AutoImport) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "GraceNote.DanganRonpa.LinLegacyTool",     "-"           ),  GraceNote.DanganRonpa.LinImport.Program.Execute) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "GraceNote.DanganRonpa.PakTextExport",     "GNDRpakEx"   ),  GraceNote.DanganRonpa.PakTextExport.Program.Execute) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "GraceNote.DanganRonpa.PakTextImport",     "GNDRpakIm"   ),  GraceNote.DanganRonpa.PakTextImport.Program.Execute) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "GraceNote.DumpDatabase",                  "GNdump"      ),  GraceNote.DumpDatabase.Program.Execute) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "GraceNote.FindEarliestGracesJapaneseId",  "-"           ),  GraceNote.FindEarliestGracesJapaneseEntry.Program.Execute) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "GraceNote.LuxPainEvtExport",              "-"           ),  GraceNote.LuxPainEvtExport.Program.Execute) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "GraceNote.LuxPainEvtImport",              "-"           ),  GraceNote.LuxPainEvtImport.Program.Execute) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "GraceNote.Trophy.TropSfmExport",          "GNtrophyex"  ),  GraceNote.Trophy.TropSfmExport.Program.Execute) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "GraceNote.Trophy.TropSfmImport",          "GNtrophyim"  ),  GraceNote.Trophy.TropSfmImport.Program.Execute) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "GraceNote.Vesperia.ScfombinImport",       "GNToVscfom"  ),  GraceNote.Vesperia.ScfombinImport.Program.Execute) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "GraceNote.Vesperia.StringDicExport",      "GNToVdicex"  ),  GraceNote.Vesperia.StringDicExport.Program.Execute) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "GraceNote.Vesperia.StringDicImport",      "GNToVdicim"  ),  GraceNote.Vesperia.StringDicImport.Importer.Execute) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "GraceNote.Vesperia.TO8CHTXExport",        "GNToVchatex" ),  GraceNote.Vesperia.TO8CHTXExport.Program.Execute) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "GraceNote.Vesperia.TO8CHTXImport",        "GNToVchatim" ),  GraceNote.Vesperia.TO8CHTXImport.Program.Execute) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "GraceNote.Vesperia.VVoicesGenerate",      "-"           ),  GraceNote.Vesperia.VVoicesGenerate.Program.Execute) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "GraceNote.XilliaScriptFileDump",          "-"           ),  GraceNote.XilliaScriptFileDump.Program.Execute) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "Other.AutoExtract",                       "autoex"      ),  Other.AutoExtract.Program.Execute) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "Other.FileToFolderRename",                "-"           ),  Other.AutoExtract.FileToFolderRename.Execute) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "Generic.ArbitraryTextDump",               "-"           ),  Generic.ArbitraryTextDump.Dump.Execute) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "Other.GoldenSunDarkDawnMsgExtract",       "-"           ),  Other.GoldenSunDarkDawnMsgExtract.Program.Execute) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "Other.NisPakEx",                          "-"           ),  Other.NisPakEx.Program.Execute) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "Other.NitroidDataBinEx",                  "-"           ),  Other.NitroidDataBinEx.Program.Execute) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "Tales.Vesperia.MapList",                  "ToVmaplist"  ),  Tales.Vesperia.MapList.Program.Execute) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "Tales.Vesperia.SpkdUnpack",               "ToVspkd"     ),  Tales.Vesperia.SpkdUnpack.Program.Execute) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "Tales.Vesperia.FPS4.Extract",             "ToVfps4e"    ),  Tales.Vesperia.FPS4.Program.Extract) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "Tales.Vesperia.FPS4.Pack",                "ToVfps4p"    ),  Tales.Vesperia.FPS4.Program.Pack) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "Tales.Abyss.FPS2.Extract",                "TotAfps2e"   ),  Tales.Abyss.FPS2.Program.Execute) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "Tales.Abyss.FPS3.Extract",                "TotAfps3e"   ),  Tales.Abyss.FPS3.Program.Execute) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "Tales.Abyss.SB7.DumpText",                "TotAsp7dump" ),  Tales.Abyss.SB7.DumpText.Execute) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "Other.TrailsInTheSkyScenarioDump",        "TrailsDump"  ),  Other.TrailsInTheSkyScenarioDump.DumpText.Execute) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "Tales.Xillia.TldatExtract",               "ToXtldate"   ),  Tales.Xillia.TldatExtract.Program.Execute) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "Tales.Xillia.TldatPack",                  "ToXtldatp"   ),  Tales.Xillia.TldatPack.Program.Execute) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "Tales.tlzc",                              "tlzc"        ),  Tales.tlzc.tlzcmain.Execute) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "Tales.Abyss.PKF.Split",                   "TotApkfspl"  ),  Tales.Abyss.PKF.Split.Execute) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "Generic.DbTextReplace",                   "-"           ),  Generic.DbTextReplace.Replacement.Replace) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "Other.PSP.GIM.LayerSplitter",             "gimSplit"    ),  Other.PSP.GIM.LayerSplitter.Splitter.Split) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "Other.PSP.GIM.HomogenizePalette",         "gimSamePal"  ),  Other.PSP.GIM.HomogenizePalette.Program.Homogenize) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "Other.PSP.GIM.GimToPng",                  "GimToPng"    ),  Other.PSP.GIM.GimToPng.GimToPng.Execute) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "Tales.DestinyRemake.TblBin.Extract",      "-"           ),  Tales.DestinyRemake.TblBin.Execute.Extract) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "Tales.DestinyRemake.MglkExtract.Extract", "-"           ),  Tales.DestinyRemake.MglkExtract.Execute.Extract) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "GraceNote.DanganRonpa.AutoFormat",        "-"           ),  GraceNote.DanganRonpa.AutoFormatting.AutoFormat.Execute) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "Other.GZip.Extract",                      "-"           ),  Other.GZip.GZipHandler.ExecuteExtract) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "GraceNote.Narisokonai.scrImport",         "-"           ),  GraceNote.Narisokonai.scrImport.Import) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "GraceNote.Narisokonai.scrExport",         "-"           ),  GraceNote.Narisokonai.scrExport.Export) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "GraceNote.FindIdenticalEntries",          "GNident"     ),  GraceNote.FindIdenticalEntries.Finder.Execute) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "MyWorldMyWay.Tbl.Dump",                   "-"           ),  MyWorldMyWay.Tbl.DumpText) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "Tales.Vesperia.T8BTMA",                   "ToVartes"    ),  Tales.Vesperia.T8BTMA.Program.Execute) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "HalfMinuteHeroSecond.S2AR.Extract",       "-"           ),  HalfMinuteHeroSecond.S2AR.ExecuteExtract) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "Pokemon.Gen5.PWT.DownloadChecksum",       "-"           ),  Pokemon.Gen5.PWT.Program.ExecuteDownloadChecksumRecalc) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "Tales.Vesperia.Scenario.Extract",         "-"           ),  Tales.Vesperia.Scenario.Program.ExecuteExtract) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "Tales.Vesperia.Scenario.Pack",            "-"           ),  Tales.Vesperia.Scenario.Program.ExecutePack) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "Tales.Vesperia.GenerateWebsite",          "-"           ),  Tales.Vesperia.Website.GenerateWebsite.Generate) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "Gust.ebm.TextDump",                       "-"           ),  Gust.ebm.TextDumper.Execute) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "Gust.ebm.EbmToSqlite",                    "-"           ),  Gust.ebm.EbmToSqlite.Execute) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "Gust.ebm.SqliteToEbm",                    "-"           ),  Gust.ebm.SqliteToEbm.Execute) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "Gust.g1t.Extract",                        "-"           ),  Gust.g1t.DDSConverter.Execute) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "GraceNote.Sting.BlazeUnion.ScriptImport", "-"           ),  GraceNote.Sting.BlazeUnionScript.Importer.Import) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "GraceNote.Sting.BlazeUnion.ScriptExport", "-"           ),  GraceNote.Sting.BlazeUnionScript.Exporter.Export) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "Generic.AddDDSHeader",                    "DDSHeader"   ),  Generic.AddDDSHeader.Program.Execute) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "Tales.Vesperia.FixXmaHeader",             "-"		   ),  Tales.Vesperia.xma.FixHeader.Execute) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "FinalFantasyCrystalChronicles.TextDumper","-"           ),  FinalFantasyCrystalChronicles.TextDumper.Execute) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "Pokemon.Gen3.HallOfFame",                 "-"           ),  Pokemon.Gen3.HallOfFame.Execute) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "Pokemon.Gen3.Save",                       "-"           ),  Pokemon.Gen3.Save.Execute) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "Tales.Vesperia.Texture.Decode",           "-"           ),  Tales.Vesperia.Texture.Decode.Execute) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "Tales.Vesperia.SaveDataParser",           "-"           ),  Tales.Vesperia.SaveData.SaveDataParser.Parse) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "AceAttorneyInvestigations.ScriptDumper",  "-"           ),  Other.AceAttorneyInvestigationsScriptDump.Dumper.Execute) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "Tales.Vesperia.SE3toNUB",                 "SE3toNUB"    ),  Tales.Vesperia.SE3.Program.ExtractToNub) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "Tales.Vesperia.SE3.Extract",              "-"           ),  Tales.Vesperia.SE3.Program.ExtractSE3) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "Tales.CPK.Extract",                       "-"           ),  Tales.CPK.Program.Extract) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "Patches.Bps.Patch",                       "-"           ),  Patches.Bps.Program.ExecutePatch) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "Generic.CompareFileLists",                "-"           ),  Generic.CompareFileLists.CompareFileLists.Execute) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "Tales.Vesperia.NUB.Extract",              "-"           ),  Tales.Vesperia.NUB.Program.ExecuteExtract) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "Tales.Vesperia.NUB.Rebuild",              "-"           ),  Tales.Vesperia.NUB.Program.ExecuteRebuild) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "HyoutaArchive.Extract",                   "-"           ),  HyoutaArchive.Program.Extract) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "HyoutaArchive.Pack",                      "-"           ),  HyoutaArchive.Program.Pack) },
			{ new KeyValuePair<ProgramName, ExecuteProgramDelegate>( new ProgramName( "Gust.AtelierIris.VoiceSplitter",          "-"           ),  Gust.AtelierIris.VoiceSplitter.Execute) },
		};
	}
}
