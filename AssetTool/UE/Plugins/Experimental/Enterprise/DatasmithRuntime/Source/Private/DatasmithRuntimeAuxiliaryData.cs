namespace AssetTool
{
    [JsonAsset("DatasmithRuntimeTHelper")]
    public class UDatasmithRuntimeTHelper : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DatasmithRuntimeAuxiliaryData")]
    public class UDatasmithRuntimeAuxiliaryData : UAssetUserData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}