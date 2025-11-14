namespace AssetTool
{
    [JsonAsset("Merge")]
    public class UMerge : UUTBBaseCommand
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}