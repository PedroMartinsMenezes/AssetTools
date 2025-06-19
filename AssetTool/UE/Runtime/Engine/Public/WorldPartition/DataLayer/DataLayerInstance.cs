namespace AssetTool
{
    [JsonAsset("DataLayerInstance")]
    public class UDataLayerInstance : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}