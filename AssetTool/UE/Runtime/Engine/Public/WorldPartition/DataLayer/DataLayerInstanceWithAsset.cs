namespace AssetTool
{
    [JsonAsset("DataLayerInstanceWithAsset")]
    public class UDataLayerInstanceWithAsset : UDataLayerInstance
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}