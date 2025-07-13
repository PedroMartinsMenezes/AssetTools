namespace AssetTool
{
    [JsonAsset("ExternalDataLayerAsset")]
    public class UExternalDataLayerAsset : UDataLayerAsset
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}