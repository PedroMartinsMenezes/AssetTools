namespace AssetTool
{
    [JsonAsset("AssetImportData")]
    public class UAssetImportData : UObject
    {
        public FString Json;

        [Location("void UAssetImportData::Serialize(FStructuredArchive::FRecord Record)")]
        public override UObject Move(Transfer transfer)
        {
            if (GlobalObjects.UESupport(EUnrealEngineObjectUE4Version.VER_UE4_ASSET_IMPORT_DATA_AS_JSON))
            {
                transfer.Move(ref Json);
            }
            base.Move(transfer);
            return this;
        }
    }
}
