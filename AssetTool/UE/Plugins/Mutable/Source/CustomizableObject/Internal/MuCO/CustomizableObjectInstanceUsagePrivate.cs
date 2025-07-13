namespace AssetTool
{
    [JsonAsset("CustomizableObjectInstanceUsagePrivate")]
    public class UCustomizableObjectInstanceUsagePrivate : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}