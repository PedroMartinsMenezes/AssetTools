namespace AssetTool
{
    [JsonAsset("AbilityTask_ApplyRootMotionMoveToForce")]
    public class UAbilityTask_ApplyRootMotionMoveToForce : UAbilityTask_ApplyRootMotion_Base
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}