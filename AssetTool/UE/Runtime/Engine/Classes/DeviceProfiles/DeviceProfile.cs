namespace AssetTool
{
    [JsonAsset("DeviceProfile")]
    public class UDeviceProfile : UTextureLODSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}