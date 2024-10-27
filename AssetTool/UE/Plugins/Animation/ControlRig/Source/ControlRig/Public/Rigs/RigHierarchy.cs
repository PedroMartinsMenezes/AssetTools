namespace AssetTool
{
    [JsonAsset("RigHierarchy")]
    public class  URigHierarchy : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}