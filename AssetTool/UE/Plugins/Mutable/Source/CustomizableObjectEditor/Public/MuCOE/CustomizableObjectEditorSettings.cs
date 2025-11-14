namespace AssetTool
{
    [JsonAsset("CustomizableObjectEditorSettings")]
    public class UCustomizableObjectEditorSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}