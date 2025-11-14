namespace AssetTool
{
    [JsonAsset("SmartObjectHashGrid")]
    public class USmartObjectHashGrid : USmartObjectSpacePartition
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}