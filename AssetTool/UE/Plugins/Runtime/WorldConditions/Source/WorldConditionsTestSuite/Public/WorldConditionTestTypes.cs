namespace AssetTool
{
    [JsonAsset("WorldConditionTestSchema")]
    public class UWorldConditionTestSchema : UWorldConditionSchema
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("WorldConditionTestCachedSchema")]
    public class UWorldConditionTestCachedSchema : UWorldConditionSchema
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("WorldConditionOwnerClass")]
    public class UWorldConditionOwnerClass : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}