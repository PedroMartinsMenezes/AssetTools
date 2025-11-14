namespace AssetTool
{
    [JsonAsset("CustomizableObjectSettings")]
    public class UCustomizableObjectSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}