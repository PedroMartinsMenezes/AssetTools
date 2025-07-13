namespace AssetTool
{
    [JsonAsset("EditorImageProvider")]
    public class UEditorImageProvider : UCustomizableSystemImageProvider
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}