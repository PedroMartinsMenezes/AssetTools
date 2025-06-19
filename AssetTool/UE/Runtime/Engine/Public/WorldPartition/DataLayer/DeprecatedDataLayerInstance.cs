namespace AssetTool
{
    [JsonAsset("DeprecatedDataLayerInstance")]
    public class UDeprecatedDataLayerInstance : UDataLayerInstance
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}