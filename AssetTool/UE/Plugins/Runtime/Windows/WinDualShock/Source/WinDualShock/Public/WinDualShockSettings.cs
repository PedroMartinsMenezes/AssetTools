namespace AssetTool
{
    [JsonAsset("DualShockExternalEndpointSettings")]
    public class UDualShockExternalEndpointSettings : UAudioEndpointSettingsBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DualShockSoundfieldEndpointSettings")]
    public class UDualShockSoundfieldEndpointSettings : USoundfieldEndpointSettingsBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DualShockSpatializationSettings")]
    public class UDualShockSpatializationSettings : USoundfieldEncodingSettingsBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}