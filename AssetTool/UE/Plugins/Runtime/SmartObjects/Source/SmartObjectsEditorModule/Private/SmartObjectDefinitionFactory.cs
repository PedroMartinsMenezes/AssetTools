namespace AssetTool
{
    [JsonAsset("SmartObjectDefinitionFactory")]
    public class USmartObjectDefinitionFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}