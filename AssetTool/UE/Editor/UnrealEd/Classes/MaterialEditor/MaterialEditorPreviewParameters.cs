namespace AssetTool
{
    [JsonAsset("MaterialEditorPreviewParameters")]
    public class UMaterialEditorPreviewParameters : UMaterialEditorParameters
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}