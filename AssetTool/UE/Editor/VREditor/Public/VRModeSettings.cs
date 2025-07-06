namespace AssetTool
{
    [JsonAsset("VRModeSettings")]
    public class UVRModeSettings : UVISettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}