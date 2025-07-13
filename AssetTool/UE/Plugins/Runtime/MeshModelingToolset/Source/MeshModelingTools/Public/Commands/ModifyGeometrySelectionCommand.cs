namespace AssetTool
{
    [JsonAsset("ModifyGeometrySelectionCommand")]
    public class UModifyGeometrySelectionCommand : UGeometrySelectionEditCommand
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ModifyGeometrySelectionCommand_Invert")]
    public class UModifyGeometrySelectionCommand_Invert : UModifyGeometrySelectionCommand
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ModifyGeometrySelectionCommand_ExpandToConnected")]
    public class UModifyGeometrySelectionCommand_ExpandToConnected : UModifyGeometrySelectionCommand
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ModifyGeometrySelectionCommand_InvertConnected")]
    public class UModifyGeometrySelectionCommand_InvertConnected : UModifyGeometrySelectionCommand
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ModifyGeometrySelectionCommand_Expand")]
    public class UModifyGeometrySelectionCommand_Expand : UModifyGeometrySelectionCommand
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ModifyGeometrySelectionCommand_Contract")]
    public class UModifyGeometrySelectionCommand_Contract : UModifyGeometrySelectionCommand
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}