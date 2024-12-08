namespace AssetTool
{
    [JsonAsset("DeprecatedDataLayerInstance")]
    public class UDeprecatedDataLayerInstance : UDataLayerInstance
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}