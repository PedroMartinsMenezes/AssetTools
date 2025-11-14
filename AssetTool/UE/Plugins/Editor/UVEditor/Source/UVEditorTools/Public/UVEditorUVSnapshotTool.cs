namespace AssetTool
{
    [JsonAsset("UVEditorUVSnapshotToolBuilder")]
    public class UUVEditorUVSnapshotToolBuilder : UInteractiveToolBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("UVEditorUVSnapshotTool")]
    public class UUVEditorUVSnapshotTool : UInteractiveTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("UVEditorBakeUVShellProperties")]
    public class UUVEditorBakeUVShellProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}