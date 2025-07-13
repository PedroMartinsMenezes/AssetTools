namespace AssetTool
{
    [JsonAsset("AbilityTask_ApplyRootMotionRadialForce")]
    public class UAbilityTask_ApplyRootMotionRadialForce : UAbilityTask_ApplyRootMotion_Base
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}