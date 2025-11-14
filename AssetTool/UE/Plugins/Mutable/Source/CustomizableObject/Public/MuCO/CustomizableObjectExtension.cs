namespace AssetTool
{
    [JsonAsset("CustomizableObjectExtension")]
    public class UCustomizableObjectExtension : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}