namespace AssetTool
{
    [JsonAsset("DeprecatedDataLayerInstance")]
    public class UDeprecatedDataLayerInstance : UDataLayerInstance
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}