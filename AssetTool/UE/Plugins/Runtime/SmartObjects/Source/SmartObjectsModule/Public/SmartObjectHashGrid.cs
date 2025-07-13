namespace AssetTool
{
    [JsonAsset("SmartObjectHashGrid")]
    public class USmartObjectHashGrid : USmartObjectSpacePartition
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}