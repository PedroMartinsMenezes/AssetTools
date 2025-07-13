namespace AssetTool
{
    [JsonAsset("SmartObjectMassBehaviorDefinition")]
    public class USmartObjectMassBehaviorDefinition : USmartObjectBehaviorDefinition
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}