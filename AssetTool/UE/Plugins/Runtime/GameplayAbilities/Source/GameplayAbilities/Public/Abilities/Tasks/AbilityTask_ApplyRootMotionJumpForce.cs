namespace AssetTool
{
    [JsonAsset("AbilityTask_ApplyRootMotionJumpForce")]
    public class UAbilityTask_ApplyRootMotionJumpForce : UAbilityTask_ApplyRootMotion_Base
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}