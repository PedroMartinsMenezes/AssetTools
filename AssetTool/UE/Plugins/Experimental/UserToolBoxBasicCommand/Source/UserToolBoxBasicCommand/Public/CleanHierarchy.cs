namespace AssetTool
{
    [JsonAsset("CleanHierarchy")]
    public class UCleanHierarchy : UUTBBaseCommand
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}