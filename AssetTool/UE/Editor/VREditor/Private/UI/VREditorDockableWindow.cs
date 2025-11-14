namespace AssetTool
{
    [JsonAsset("VREditorDockableWindow")]
    public class AVREditorDockableWindow : AVREditorFloatingUI
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DockableWindowDragOperation")]
    public class UDockableWindowDragOperation : UViewportDragOperation
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}