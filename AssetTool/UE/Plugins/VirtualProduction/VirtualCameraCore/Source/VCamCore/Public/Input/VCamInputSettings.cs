namespace AssetTool
{
    [JsonAsset("VCamInputSettings")]
    public class UVCamInputSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}