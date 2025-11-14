namespace AssetTool
{
    [JsonAsset("SmartObjectMassBehaviorDefinition")]
    public class USmartObjectMassBehaviorDefinition : USmartObjectBehaviorDefinition
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}