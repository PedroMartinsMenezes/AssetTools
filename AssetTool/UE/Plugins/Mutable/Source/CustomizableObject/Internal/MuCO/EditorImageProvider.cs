namespace AssetTool
{
    [JsonAsset("EditorImageProvider")]
    public class UEditorImageProvider : UCustomizableSystemImageProvider
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}