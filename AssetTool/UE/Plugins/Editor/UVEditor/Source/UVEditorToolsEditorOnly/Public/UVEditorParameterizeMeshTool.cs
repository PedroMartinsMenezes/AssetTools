namespace AssetTool
{
    [JsonAsset("UVEditorParameterizeMeshToolBuilder")]
    public class UUVEditorParameterizeMeshToolBuilder : UInteractiveToolBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("UVEditorParameterizeMeshTool")]
    public class UUVEditorParameterizeMeshTool : UInteractiveTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}