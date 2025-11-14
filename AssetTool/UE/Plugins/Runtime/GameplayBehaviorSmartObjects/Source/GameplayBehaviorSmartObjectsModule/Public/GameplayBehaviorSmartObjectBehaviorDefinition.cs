namespace AssetTool
{
    [JsonAsset("GameplayBehaviorSmartObjectBehaviorDefinition")]
    public class UGameplayBehaviorSmartObjectBehaviorDefinition : USmartObjectBehaviorDefinition
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}