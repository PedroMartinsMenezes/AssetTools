namespace AssetTool
{
    [JsonAsset("GizmoSettings")]
    public class UGizmoSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}