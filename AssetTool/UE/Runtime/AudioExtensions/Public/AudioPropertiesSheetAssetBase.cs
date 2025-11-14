namespace AssetTool
{
    [JsonAsset("AudioPropertiesSheetAssetBase")]
    public class UAudioPropertiesSheetAssetBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}