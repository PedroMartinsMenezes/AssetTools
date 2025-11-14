namespace AssetTool
{
    [JsonAsset("PCGApplyHierarchySettings")]
    public class UPCGApplyHierarchySettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}