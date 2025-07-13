namespace AssetTool
{
    [JsonAsset("AbilityTask_ApplyRootMotionMoveToActorForce")]
    public class UAbilityTask_ApplyRootMotionMoveToActorForce : UAbilityTask_ApplyRootMotion_Base
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}