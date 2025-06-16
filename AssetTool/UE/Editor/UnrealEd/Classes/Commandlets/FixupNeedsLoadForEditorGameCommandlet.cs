namespace AssetTool
{
    [JsonAsset("FixupNeedsLoadForEditorGameCommandlet")]
    public class UFixupNeedsLoadForEditorGameCommandlet : UResavePackagesCommandlet
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}