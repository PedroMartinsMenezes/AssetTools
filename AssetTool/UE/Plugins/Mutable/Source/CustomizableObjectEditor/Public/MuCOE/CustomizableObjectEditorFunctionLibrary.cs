namespace AssetTool
{
    [JsonAsset("CustomizableObjectEditorFunctionLibrary")]
    public class UCustomizableObjectEditorFunctionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}