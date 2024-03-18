namespace AssetTool
{
    [Location("void UAssetImportData::Serialize(FStructuredArchive::FRecord Record)")]
    public class UAssetImportData : UObject
    {
        public const string TypeName = "AssetImportData";

        public FAssetImportInfo SourceData;

        public new UAssetImportData Read(BinaryReader reader)
        {
            if (GlobalObjects.UESupport(EUnrealEngineObjectUE4Version.VER_UE4_ASSET_IMPORT_DATA_AS_JSON))
            {
                SourceData = new();
                FString json = null;
                reader.Read(ref json);
                SourceData.SourceFiles = json.Value.ToObject<List<FAssetImportInfo.FSourceFile>>();
            }
            base.Read(reader);
            return this;
        }

        public new void Write(BinaryWriter writer)
        {
            if (GlobalObjects.UESupport(EUnrealEngineObjectUE4Version.VER_UE4_ASSET_IMPORT_DATA_AS_JSON))
            {
                string json = SourceData.SourceFiles.ToJson();
                writer.Write(new FString(json));
            }
            base.Write(writer);
        }
    }
}
