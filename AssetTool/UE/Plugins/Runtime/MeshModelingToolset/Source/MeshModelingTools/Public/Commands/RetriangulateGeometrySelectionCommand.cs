namespace AssetTool
{
    [JsonAsset("RetriangulateGeometrySelectionCommand")]
    public class URetriangulateGeometrySelectionCommand : UGeometrySelectionEditCommand
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}