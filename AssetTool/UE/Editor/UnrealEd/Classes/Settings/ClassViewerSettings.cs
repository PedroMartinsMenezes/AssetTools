namespace AssetTool
{
    [JsonAsset("ClassViewerSettings")]
    public class UClassViewerSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}