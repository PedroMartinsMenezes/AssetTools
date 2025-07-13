namespace AssetTool
{
    [JsonAsset("DeleteGeometrySelectionCommand")]
    public class UDeleteGeometrySelectionCommand : UGeometrySelectionEditCommand
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}