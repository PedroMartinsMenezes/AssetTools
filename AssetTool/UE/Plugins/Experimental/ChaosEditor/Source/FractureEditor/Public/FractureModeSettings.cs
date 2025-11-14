namespace AssetTool
{
    [JsonAsset("FractureModeSettings")]
    public class UFractureModeSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}