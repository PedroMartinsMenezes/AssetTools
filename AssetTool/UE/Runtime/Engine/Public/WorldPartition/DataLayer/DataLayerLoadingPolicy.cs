namespace AssetTool
{
    [JsonAsset("DataLayerLoadingPolicy")]
    public class UDataLayerLoadingPolicy : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}