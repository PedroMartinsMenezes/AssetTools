namespace AssetTool
{
    [JsonAsset("GizmoSettings")]
    public class UGizmoSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}