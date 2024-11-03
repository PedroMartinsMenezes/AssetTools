namespace AssetTool
{
    [JsonAsset("RigHierarchy")]
    public class URigHierarchy : UObject
    {
        [Location("void URigHierarchy::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}