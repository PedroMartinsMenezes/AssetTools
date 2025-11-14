namespace AssetTool
{
    [JsonAsset("VRModeSettings")]
    public class UVRModeSettings : UVISettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}