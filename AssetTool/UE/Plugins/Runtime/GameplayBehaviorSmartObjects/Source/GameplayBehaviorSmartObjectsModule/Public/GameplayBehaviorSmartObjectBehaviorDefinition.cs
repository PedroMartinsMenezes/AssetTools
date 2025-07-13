namespace AssetTool
{
    [JsonAsset("GameplayBehaviorSmartObjectBehaviorDefinition")]
    public class UGameplayBehaviorSmartObjectBehaviorDefinition : USmartObjectBehaviorDefinition
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}