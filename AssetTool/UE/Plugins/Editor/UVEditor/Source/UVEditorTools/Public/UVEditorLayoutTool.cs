namespace AssetTool
{
    [JsonAsset("UVEditorLayoutToolBuilder")]
    public class UUVEditorLayoutToolBuilder : UInteractiveToolBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("UVEditorLayoutTool")]
    public class UUVEditorLayoutTool : UInteractiveTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}