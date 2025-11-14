namespace AssetTool
{
    [JsonAsset("UVEditorParameterizeMeshToolBuilder")]
    public class UUVEditorParameterizeMeshToolBuilder : UInteractiveToolBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("UVEditorParameterizeMeshTool")]
    public class UUVEditorParameterizeMeshTool : UInteractiveTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}