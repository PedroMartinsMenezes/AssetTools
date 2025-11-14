namespace AssetTool
{
    [JsonAsset("CustomizableObjectFactory")]
    public class UCustomizableObjectFactory : UFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}