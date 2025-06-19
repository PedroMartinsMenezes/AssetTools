namespace AssetTool
{
    [JsonAsset("RigHierarchyController")]
    public class URigHierarchyController : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}