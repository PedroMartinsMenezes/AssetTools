namespace AssetTool
{
    [JsonAsset("SmartObjectOctree")]
    public class USmartObjectOctree : USmartObjectSpacePartition
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}