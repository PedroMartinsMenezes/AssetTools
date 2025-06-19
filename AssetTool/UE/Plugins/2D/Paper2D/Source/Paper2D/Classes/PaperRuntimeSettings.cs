namespace AssetTool
{
    [JsonAsset("PaperRuntimeSettings")]
    public class UPaperRuntimeSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}