namespace AssetTool
{
    [JsonAsset("AudioLinkSettingsAbstract")]
    public class UAudioLinkSettingsAbstract : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}