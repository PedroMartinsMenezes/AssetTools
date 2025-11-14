namespace AssetTool
{
    [JsonAsset("DisconnectGeometrySelectionCommand")]
    public class UDisconnectGeometrySelectionCommand : UGeometrySelectionEditCommand
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}