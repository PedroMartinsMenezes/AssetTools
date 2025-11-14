namespace AssetTool
{
    [JsonAsset("AudioEndpointSettingsBase")]
    public class UAudioEndpointSettingsBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DummyEndpointSettings")]
    public class UDummyEndpointSettings : UAudioEndpointSettingsBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}