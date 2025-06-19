namespace AssetTool
{
    [JsonAsset("DataLayerAsset")]
    public class UDataLayerAsset : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}