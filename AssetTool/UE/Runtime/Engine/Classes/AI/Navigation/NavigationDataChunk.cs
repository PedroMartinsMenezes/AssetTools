namespace AssetTool
{
    [JsonAsset("NavigationDataChunk")]
    public class UNavigationDataChunk : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}