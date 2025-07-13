namespace AssetTool
{
    [JsonAsset("CustomizableObjectEditorSettings")]
    public class UCustomizableObjectEditorSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}