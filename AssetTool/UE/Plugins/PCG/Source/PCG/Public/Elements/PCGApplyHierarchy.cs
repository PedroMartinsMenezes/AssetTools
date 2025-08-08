namespace AssetTool
{
    [JsonAsset("PCGApplyHierarchySettings")]
    public class UPCGApplyHierarchySettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}