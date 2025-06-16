namespace AssetTool
{
    [JsonAsset("MaterialEditorPreviewParameters")]
    public class UMaterialEditorPreviewParameters : UMaterialEditorParameters
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}