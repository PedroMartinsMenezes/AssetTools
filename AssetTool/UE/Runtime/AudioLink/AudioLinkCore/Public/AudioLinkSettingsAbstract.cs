namespace AssetTool
{
    [JsonAsset("AudioLinkSettingsAbstract")]
    public class UAudioLinkSettingsAbstract : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}