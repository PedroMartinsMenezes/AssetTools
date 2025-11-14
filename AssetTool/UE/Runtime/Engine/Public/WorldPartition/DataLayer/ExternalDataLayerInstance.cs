namespace AssetTool
{
    [JsonAsset("ExternalDataLayerInstance")]
    public class UExternalDataLayerInstance : UDataLayerInstanceWithAsset
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}