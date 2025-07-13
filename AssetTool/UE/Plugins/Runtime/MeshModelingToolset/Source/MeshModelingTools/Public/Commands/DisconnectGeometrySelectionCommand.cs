namespace AssetTool
{
    [JsonAsset("DisconnectGeometrySelectionCommand")]
    public class UDisconnectGeometrySelectionCommand : UGeometrySelectionEditCommand
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}