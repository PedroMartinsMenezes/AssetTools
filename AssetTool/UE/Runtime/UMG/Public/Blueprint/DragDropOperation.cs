namespace AssetTool
{
    [JsonAsset("DragDropOperation")]
    public class UDragDropOperation : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}