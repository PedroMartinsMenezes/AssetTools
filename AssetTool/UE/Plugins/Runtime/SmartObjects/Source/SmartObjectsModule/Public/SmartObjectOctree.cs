namespace AssetTool
{
    [JsonAsset("SmartObjectOctree")]
    public class USmartObjectOctree : USmartObjectSpacePartition
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}