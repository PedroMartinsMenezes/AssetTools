namespace AssetTool
{
    [JsonAsset("VREditorDockableWindow")]
    public class AVREditorDockableWindow : AVREditorFloatingUI
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DockableWindowDragOperation")]
    public class UDockableWindowDragOperation : UViewportDragOperation
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}