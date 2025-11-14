namespace AssetTool
{
    [JsonAsset("AbilityTask_ApplyRootMotionConstantForce")]
    public class UAbilityTask_ApplyRootMotionConstantForce : UAbilityTask_ApplyRootMotion_Base
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}