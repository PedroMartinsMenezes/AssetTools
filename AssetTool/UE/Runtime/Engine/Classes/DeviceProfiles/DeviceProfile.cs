namespace AssetTool
{
    [JsonAsset("DeviceProfile")]
    public class UDeviceProfile : UTextureLODSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}