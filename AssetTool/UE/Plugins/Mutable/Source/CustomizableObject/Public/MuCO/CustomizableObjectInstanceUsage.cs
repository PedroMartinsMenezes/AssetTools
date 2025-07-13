namespace AssetTool
{
    [JsonAsset("CustomizableObjectInstanceUsage")]
    public class UCustomizableObjectInstanceUsage : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}