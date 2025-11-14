namespace AssetTool
{
    [JsonAsset("CleanHierarchy")]
    public class UCleanHierarchy : UUTBBaseCommand
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}