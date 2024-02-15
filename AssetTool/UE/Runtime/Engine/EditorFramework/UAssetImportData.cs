using static AssetTool.FAssetImportInfo;

namespace AssetTool
{
    [Location("void UAssetImportData::Serialize(FStructuredArchive::FRecord Record)")]
    public class UAssetImportData : UObject
    {
        public const string TypeName = "AssetImportData";

        public FAssetImportInfo SourceData;
    }

    public static class UAssetImportDataExt
    {
        public static void Write(this BinaryWriter writer, UAssetImportData item)
        {
            if (GlobalObjects.UESupport(EUnrealEngineObjectUE4Version.VER_UE4_ASSET_IMPORT_DATA_AS_JSON))
            {
                string json = item.SourceData.SourceFiles.ToJson();
                writer.Write(new FString(json));
            }
            writer.Write((UObject)item);
        }

        public static UAssetImportData Read(this BinaryReader reader, UAssetImportData item)
        {
            if (GlobalObjects.UESupport(EUnrealEngineObjectUE4Version.VER_UE4_ASSET_IMPORT_DATA_AS_JSON))
            {
                item.SourceData = new();
                FString json = null;
                reader.Read(ref json);
                item.SourceData.SourceFiles = json.Value.ToObject<List<FSourceFile>>();
            }
            reader.Read((UObject)item);
            return item;
        }
    }
}
