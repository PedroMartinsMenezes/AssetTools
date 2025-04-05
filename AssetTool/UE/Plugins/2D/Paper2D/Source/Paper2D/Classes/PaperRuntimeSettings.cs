namespace AssetTool
{
    [JsonAsset("PaperRuntimeSettings")]
    public class UPaperRuntimeSettings : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}