namespace AssetTool
{
    [JsonAsset("SingleModifierPerNodeWithTargetSettings")]
    public class USingleModifierPerNodeWithTargetSettings : UBaseModifierGroup
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TargetModifierPerNodeHierarchyRules")]
    public class UTargetModifierPerNodeHierarchyRules : UModifierHierarchyRules
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}