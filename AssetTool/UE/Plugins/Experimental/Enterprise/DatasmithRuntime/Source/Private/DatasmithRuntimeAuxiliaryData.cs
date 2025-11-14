namespace AssetTool
{
    [JsonAsset("DatasmithRuntimeTHelper")]
    public class UDatasmithRuntimeTHelper : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DatasmithRuntimeAuxiliaryData")]
    public class UDatasmithRuntimeAuxiliaryData : UAssetUserData
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}