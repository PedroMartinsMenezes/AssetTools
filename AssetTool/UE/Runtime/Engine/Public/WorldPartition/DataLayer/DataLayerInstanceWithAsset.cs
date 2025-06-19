namespace AssetTool
{
    [JsonAsset("DataLayerInstanceWithAsset")]
    public class UDataLayerInstanceWithAsset : UDataLayerInstance
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}