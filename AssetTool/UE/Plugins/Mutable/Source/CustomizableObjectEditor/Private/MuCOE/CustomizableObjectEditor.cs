namespace AssetTool
{
    [JsonAsset("UpdateClassWrapper")]
    public class UUpdateClassWrapper : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CustomizableObjectEditorTextureStats")]
    public class UCustomizableObjectEditorTextureStats : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}