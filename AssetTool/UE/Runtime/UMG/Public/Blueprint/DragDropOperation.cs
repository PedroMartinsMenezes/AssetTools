namespace AssetTool
{
    [JsonAsset("DragDropOperation")]
    public class UDragDropOperation : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}