namespace AssetTool
{
    [JsonAsset("RigHierarchyController")]
    public class URigHierarchyController : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}