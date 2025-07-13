namespace AssetTool
{
    [JsonAsset("CustomizableObjectFactory")]
    public class UCustomizableObjectFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}