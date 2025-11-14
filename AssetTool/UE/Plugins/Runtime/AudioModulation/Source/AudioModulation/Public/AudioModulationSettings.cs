namespace AssetTool
{
    [JsonAsset("AudioModulationSettings")]
    public class UAudioModulationSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}