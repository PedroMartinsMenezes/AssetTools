namespace AssetTool
{
    [JsonAsset("CustomizableObjectEditorFunctionLibrary")]
    public class UCustomizableObjectEditorFunctionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}