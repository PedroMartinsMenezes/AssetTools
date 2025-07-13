namespace AssetTool
{
    [JsonAsset("AudioModulationSettings")]
    public class UAudioModulationSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}