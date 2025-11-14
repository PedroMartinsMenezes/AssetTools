namespace AssetTool
{
    [JsonAsset("DragDropOperation")]
    public class UDragDropOperation : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}