namespace AssetTool
{
    [JsonAsset("K2Node_CreateDragDropOperation")]
    public class UK2Node_CreateDragDropOperation : UK2Node_ConstructObjectFromClass
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}