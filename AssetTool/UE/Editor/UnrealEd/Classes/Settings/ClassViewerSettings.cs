namespace AssetTool
{
    [JsonAsset("ClassViewerSettings")]
    public class UClassViewerSettings : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}