namespace AssetTool
{
    [JsonAsset("ExternalDataLayerAsset")]
    public class UExternalDataLayerAsset : UDataLayerAsset
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}