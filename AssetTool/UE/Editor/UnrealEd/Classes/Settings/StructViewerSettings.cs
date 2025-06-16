namespace AssetTool
{
    [JsonAsset("StructViewerSettings")]
    public class UStructViewerSettings : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}