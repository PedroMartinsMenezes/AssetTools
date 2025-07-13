namespace AssetTool
{
    [JsonAsset("GeometrySelectionEditCommandArguments")]
    public class UGeometrySelectionEditCommandArguments : UInteractiveCommandArguments
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("GeometrySelectionEditCommandResult")]
    public class UGeometrySelectionEditCommandResult : UInteractiveCommandResult
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("GeometrySelectionEditCommand")]
    public class UGeometrySelectionEditCommand : UInteractiveCommand
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}