namespace AssetTool
{
    [JsonAsset("DeleteGeometrySelectionCommand")]
    public class UDeleteGeometrySelectionCommand : UGeometrySelectionEditCommand
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}