namespace AssetTool
{
    [JsonAsset("ExternalDataLayerInstance")]
    public class UExternalDataLayerInstance : UDataLayerInstanceWithAsset
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}