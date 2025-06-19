namespace AssetTool
{
    [JsonAsset("FixupNeedsLoadForEditorGameCommandlet")]
    public class UFixupNeedsLoadForEditorGameCommandlet : UResavePackagesCommandlet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}