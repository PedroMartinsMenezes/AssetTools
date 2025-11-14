namespace AssetTool
{
    [JsonAsset("GizmoEdModeSettings")]
    public class UGizmoEdModeSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("GizmoEdMode")]
    public class UGizmoEdMode : UEdMode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}