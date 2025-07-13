namespace AssetTool
{
    [JsonAsset("SmartObjectSpacePartition")]
    public class USmartObjectSpacePartition : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SmartObjectSlotValidationFilter")]
    public class USmartObjectSlotValidationFilter : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}