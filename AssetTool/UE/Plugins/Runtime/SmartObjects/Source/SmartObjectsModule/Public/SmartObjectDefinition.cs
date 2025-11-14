namespace AssetTool
{
    [JsonAsset("SmartObjectBehaviorDefinition")]
    public class USmartObjectBehaviorDefinition : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SmartObjectDefinition")]
    public class USmartObjectDefinition : UDataAsset
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}