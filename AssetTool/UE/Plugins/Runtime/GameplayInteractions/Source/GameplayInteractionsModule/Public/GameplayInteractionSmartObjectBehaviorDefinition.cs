namespace AssetTool
{
    [JsonAsset("GameplayInteractionSmartObjectBehaviorDefinition")]
    public class UGameplayInteractionSmartObjectBehaviorDefinition : USmartObjectBehaviorDefinition
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}