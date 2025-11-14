namespace AssetTool
{
    [JsonAsset("CustomizableObjectInstanceUsage")]
    public class UCustomizableObjectInstanceUsage : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}