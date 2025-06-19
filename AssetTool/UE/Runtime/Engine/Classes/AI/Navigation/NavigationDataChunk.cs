namespace AssetTool
{
    [JsonAsset("NavigationDataChunk")]
    public class UNavigationDataChunk : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}