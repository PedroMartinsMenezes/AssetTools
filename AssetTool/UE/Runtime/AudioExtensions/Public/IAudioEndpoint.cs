namespace AssetTool
{
    [JsonAsset("AudioEndpointSettingsBase")]
    public class UAudioEndpointSettingsBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DummyEndpointSettings")]
    public class UDummyEndpointSettings : UAudioEndpointSettingsBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}