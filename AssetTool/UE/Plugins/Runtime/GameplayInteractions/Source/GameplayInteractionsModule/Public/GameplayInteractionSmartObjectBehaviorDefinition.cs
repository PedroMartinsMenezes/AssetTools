namespace AssetTool
{
    [JsonAsset("GameplayInteractionSmartObjectBehaviorDefinition")]
    public class UGameplayInteractionSmartObjectBehaviorDefinition : USmartObjectBehaviorDefinition
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}