namespace AssetTool
{
    [JsonAsset("VCamInputSettings")]
    public class UVCamInputSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}