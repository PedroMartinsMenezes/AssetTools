namespace AssetTool
{
    [JsonAsset("AbilityTask_ApplyRootMotionConstantForce")]
    public class UAbilityTask_ApplyRootMotionConstantForce : UAbilityTask_ApplyRootMotion_Base
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}