namespace AssetTool
{
    [JsonAsset("RetriangulateGeometrySelectionCommand")]
    public class URetriangulateGeometrySelectionCommand : UGeometrySelectionEditCommand
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}