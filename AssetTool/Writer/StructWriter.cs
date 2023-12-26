using AssetTool.Model;
using AssetTool.Service;

namespace AssetTool.Writer
{
    public static class StructWriter
    {
        public static string Path = "C:\\UE\\IntroProjectCpp\\Content\\Lab\\S_Endereco2.dat";
        public static string PathExpected = "C:\\UE\\IntroProjectCpp\\Content\\Lab\\S_Endereco.uasset";

        public static void SaveStruct()
        {
            var writer = new BinaryWriter(File.Open(Path, FileMode.Create));
            try
            {
                StructAsset asset = GetStructAsset();
                writer.Write(asset);
            }
            finally
            {
                if (writer is { })
                    writer.Close();
            }
        }

        private static StructAsset GetStructAsset()
        {
            var summary = GetPackageFileSummary();

            var nameMap = GetNameMap();
            summary.NameCount = nameMap.Count;

            var importMap = GetImportMap();
            summary.ImportCount = 6; // importMap.Count;

            return new StructAsset
            {
                PackageFileSummary = summary,
                NameMap = nameMap,
                ImportMap = importMap
            };
        }

        private static FPackageFileSummary GetPackageFileSummary()
        {
            var Sum = new FPackageFileSummary();

            Sum.Tag = -1641380927;

            Sum.LegacyFileVersion = -8;
            Sum.LegacyUE3Version = 864;

            Sum.FileVersionUE.FileVersionUE4 = 522;
            Sum.FileVersionUE.FileVersionUE5 = 1009;
            Sum.FileVersionLicenseeUE = 0;

            Sum.CustomVersionContainer.Add(04, "375EC13C-06E4-48FB-B500-84F0262A717E");
            Sum.CustomVersionContainer.Add(37, "CFFC743F-43B0-4480-9391-14DF171D2073");
            Sum.CustomVersionContainer.Add(47, "D89B5E42-24BD-4D46-8412-ACA8DF641779");
            Sum.CustomVersionContainer.Add(40, "E4B068ED-F494-42E9-A231-DA0B2E46BB41");

            Sum.TotalHeaderSize = 2777;
            Sum.PackageName = "/Game/Lab/S_Endereco";

            Sum.PackageFlags = 0;
            Sum.NameCount = 64;
            Sum.NameOffset = 406;
            Sum.SoftObjectPathsCount = 1;
            Sum.SoftObjectPathsOffset = 2060;
            Sum.LocalizationId = "F2C39EE34438D2D11BCA9BE4B49FD4BB";
            Sum.GatherableTextDataCount = 0;
            Sum.GatherableTextDataOffset = 2080;
            Sum.ExportCount = 3;
            Sum.ExportOffset = 2320;
            Sum.ImportCount = 6;
            Sum.ImportOffset = 2080;
            Sum.DependsOffset = 2608;
            Sum.SoftPackageReferencesCount = 0;
            Sum.SoftPackageReferencesOffset = 2620;
            Sum.SearchableNamesOffset = 2620;
            Sum.ThumbnailTableOffset = 2636;
            Sum.Guid = new Guid("F542184A-4CB1-0F09-B220-E99C7E04D5ED");
            Sum.PersistentGuid = new Guid("1D422EA2-4FBF-3347-B155-6695C91C5934");
            Sum.AddGeneration(3, 64);
            Sum.SavedByEngineVersion.Set(5, 3, 2, 29314046, "++UE5+Release-5.3");
            Sum.CompatibleWithEngineVersion.Set(5, 3, 0, 27405482, "++UE5+Release-5.3");
            Sum.CompressionFlags = 0;
            Sum.CompressedChunkSize = 0;
            Sum.PackageSource = 742339551;
            Sum.AdditionalPackagesToCookSize = 0;
            Sum.AssetRegistryDataOffset = 2681;//
            Sum.BulkDataStartOffset = 8054;//
            Sum.WorldTileInfoDataOffset = 0;
            Sum.ChunkIDsSize = 0;
            Sum.PreloadDependencyCount = -1;
            Sum.PreloadDependencyOffset = 2777;
            Sum.NamesReferencedFromExportDataCount = 53;
            Sum.PayloadTocOffset = 8058;
            Sum.DataResourceOffset = 0;

            return Sum;
        }

        private static List<FNameEntrySerialized> GetNameMap()
        {
            var list = new List<FNameEntrySerialized>();

            list.Add("ArrayProperty", 45129, 27107);
            list.Add("bDontEditOnInstance", 41658, 53139);
            list.Add("bEnable3dWidget", 31682, 3678);
            list.Add("bEnableMultiLineText", 11471, 45844);
            list.Add("bEnableSaveGame", 36220, 34519);
            list.Add("BlueprintType", 4364, 57234);
            list.Add("BoolProperty", 1040, 35504);
            list.Add("bTerminalIsConst", 32836, 20288);
            list.Add("bTerminalIsUObjectWrapper", 25205, 16231);
            list.Add("bTerminalIsWeakPointer", 64909, 41462);
            list.Add("Category", 32503, 50580);
            list.Add("CEP_7_6A4D2F2F4894C5B51543D58961680CB1", 41139, 64008);
            list.Add("Cidade_10_C7B765EE463B55F13834C982D768BB1B", 10564, 30446);
            list.Add("Complemento_14_FE95298F499E9FFF6D1A398A2D694BE8", 34908, 46283);
            list.Add("ContainerType", 5548, 39309);
            list.Add("CurrentDefaultValue", 26722, 59645);
            list.Add("DefaultValue", 50704, 13300);
            list.Add("DisplayName", 38266, 17126);
            list.Add("EdGraphTerminalType", 30369, 28468);
            list.Add("EditorData", 18624, 53671);
            list.Add("EnumProperty", 55121, 16541);
            list.Add("EPinContainerType", 55110, 14339);
            list.Add("EPinContainerType::None", 21905, 52619);
            list.Add("FriendlyName", 50435, 3018);
            list.Add("Guid", 20547, 26874);
            list.Add("int", 4820, 5556);
            list.Add("IntProperty", 54181, 18998);
            list.Add("MakeStructureDefaultValue", 50001, 55534);
            list.Add("NameProperty", 62082, 18952);
            list.Add("None", 1012, 3525);
            list.Add("Numero_5_64A2ADFC4BF1FA294D3F3A9C9284160B", 64532, 38797);
            list.Add("ObjectProperty", 56129, 60083);
            list.Add("PackageLocalizationNamespace", 29714, 34937);
            list.Add("PinValueType", 8327, 52305);
            list.Add("Rua_2_A8F3454A42017B04C4403E9F8F7D8E5C", 9720, 15670);
            list.Add("SoftObjectProperty", 19291, 64174);
            list.Add("string", 44326, 5451);
            list.Add("StrProperty", 49467, 9330);
            list.Add("StructProperty", 48, 64668);
            list.Add("StructVariableDescription", 2144, 58815);
            list.Add("SubCategory", 60880, 13743);
            list.Add("SubCategoryObject", 5098, 44450);
            list.Add("TerminalCategory", 33058, 57178);
            list.Add("TerminalSubCategory", 53832, 39772);
            list.Add("TerminalSubCategoryObject", 59027, 3045);
            list.Add("Tooltip", 60085, 26111);
            list.Add("ToolTip", 60085, 48647);
            list.Add("UF_12_A3965E4C416514A9ECDA93AFC9373E9F", 62300, 30219);
            list.Add("UInt32Property", 11486, 19000);
            list.Add("UniqueNameId", 43850, 29401);
            list.Add("VarGuid", 12676, 32964);
            list.Add("VariablesDescriptions", 38538, 28607);
            list.Add("VarName", 31998, 12550);
            list.Add("/Game/Lab/S_Endereco", 7123, 28176);
            list.Add("/Script/CoreUObject", 18936, 15917);
            list.Add("/Script/Engine", 16518, 18821);
            list.Add("/Script/UnrealEd", 1068, 2199);
            list.Add("Class", 30580, 37240);
            list.Add("MetaData", 32996, 37812);
            list.Add("Package", 18291, 5512);
            list.Add("PackageMetaData", 11421, 26020);
            list.Add("S_Endereco", 35746, 10699);
            list.Add("UserDefinedStruct", 48003, 59397);
            list.Add("UserDefinedStructEditorData", 22697, 27736);

            return list;
        }

        private static List<FObjectImport> GetImportMap()
        {
            var list = new List<FObjectImport>();

            list.Add("/Script/CoreUObject", "Class", -4, "MetaData", "None", false);
            list.Add("/Script/CoreUObject", "Class", -5, "UserDefinedStruct", "None", false);

            return list;
        }
    }
}
