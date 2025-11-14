namespace AssetTool
{
    [JsonAsset("AudioSettings")]
    public class UAudioSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}