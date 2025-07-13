namespace AssetTool
{
    [JsonAsset("GameplayBehaviorConfig_BehaviorTree")]
    public class UGameplayBehaviorConfig_BehaviorTree : UGameplayBehaviorConfig
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}