namespace AssetTool
{
    [JsonAsset("AudioPropertiesSheetAssetBase")]
    public class UAudioPropertiesSheetAssetBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}