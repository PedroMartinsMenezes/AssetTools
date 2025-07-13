namespace AssetTool
{
    [JsonAsset("AudioBusSubsystem")]
    public class UAudioBusSubsystem : UAudioEngineSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}