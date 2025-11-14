namespace AssetTool
{
    [JsonAsset("AvaMaskSettings")]
    public class UAvaMaskSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}