namespace AssetTool
{
    [JsonAsset("SmartObjectBehaviorDefinition")]
    public class USmartObjectBehaviorDefinition : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SmartObjectDefinition")]
    public class USmartObjectDefinition : UDataAsset
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}