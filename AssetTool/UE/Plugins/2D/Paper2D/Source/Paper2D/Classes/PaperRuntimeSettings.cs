namespace AssetTool
{
    [JsonAsset("PaperRuntimeSettings")]
    public class UPaperRuntimeSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}