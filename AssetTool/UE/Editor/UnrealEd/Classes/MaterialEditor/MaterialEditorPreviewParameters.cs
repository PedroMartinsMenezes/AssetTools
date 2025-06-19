namespace AssetTool
{
    [JsonAsset("MaterialEditorPreviewParameters")]
    public class UMaterialEditorPreviewParameters : UMaterialEditorParameters
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}