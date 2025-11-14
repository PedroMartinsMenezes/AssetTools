namespace AssetTool
{
    [JsonAsset("FixupNeedsLoadForEditorGameCommandlet")]
    public class UFixupNeedsLoadForEditorGameCommandlet : UResavePackagesCommandlet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}