namespace AssetTool
{
    [JsonAsset("CustomizableObjectInstance")]
    public class UCustomizableObjectInstance : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}