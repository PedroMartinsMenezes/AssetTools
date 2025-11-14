namespace AssetTool
{
    [JsonAsset("CustomizableObjectLayout")]
    public class UCustomizableObjectLayout : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}