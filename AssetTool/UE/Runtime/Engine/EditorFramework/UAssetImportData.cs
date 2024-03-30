namespace AssetTool
{
    [Location("void UAssetImportData::Serialize(FStructuredArchive::FRecord Record)")]
    public class UAssetImportData : UObject
    {
        public const string TypeName = "AssetImportData";

        public FString Json;

        public new UAssetImportData Read(BinaryReader reader)
        {
            if (GlobalObjects.UESupport(EUnrealEngineObjectUE4Version.VER_UE4_ASSET_IMPORT_DATA_AS_JSON))
            {
                reader.Read(ref Json);
            }
            base.Read(reader);
            return this;
        }

        public new void Write(BinaryWriter writer)
        {
            if (GlobalObjects.UESupport(EUnrealEngineObjectUE4Version.VER_UE4_ASSET_IMPORT_DATA_AS_JSON))
            {
                writer.Write(Json);
            }
            base.Write(writer);
        }
    }
}
