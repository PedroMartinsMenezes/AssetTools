namespace AssetTool
{
    [JsonAsset("SingleModifierPerNodeWithTargetSettings")]
    public class USingleModifierPerNodeWithTargetSettings : UBaseModifierGroup
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TargetModifierPerNodeHierarchyRules")]
    public class UTargetModifierPerNodeHierarchyRules : UModifierHierarchyRules
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}