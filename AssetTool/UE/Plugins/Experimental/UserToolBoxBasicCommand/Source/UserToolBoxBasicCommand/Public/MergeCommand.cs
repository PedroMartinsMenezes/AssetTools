namespace AssetTool
{
    [JsonAsset("Merge")]
    public class UMerge : UUTBBaseCommand
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}