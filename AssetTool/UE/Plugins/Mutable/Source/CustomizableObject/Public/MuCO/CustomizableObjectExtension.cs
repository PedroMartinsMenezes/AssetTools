namespace AssetTool
{
    [JsonAsset("CustomizableObjectExtension")]
    public class UCustomizableObjectExtension : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}