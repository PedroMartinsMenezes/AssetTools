namespace AssetTool
{
    [Location("void UAssetImportData::Serialize(FStructuredArchive::FRecord Record)")]
    public class UAssetImportData : UObject
    {
        public const string TypeName = "AssetImportData";

        public FString Json;

        public new UAssetImportData Move(Transfer transfer)
        {
            if (GlobalObjects.UESupport(EUnrealEngineObjectUE4Version.VER_UE4_ASSET_IMPORT_DATA_AS_JSON))
            {
                transfer.Move(ref Json);
            }
            base.Move(transfer);
            return this;
        }

        //public new void Write(BinaryWriter writer)
        //{
        //    var transfer = GlobalObjects.Transfer;
        //    if (GlobalObjects.UESupport(EUnrealEngineObjectUE4Version.VER_UE4_ASSET_IMPORT_DATA_AS_JSON))
        //    {
        //        transfer.Move(ref Json);
        //    }
        //    base.Write(writer);
        //}
    }
}
