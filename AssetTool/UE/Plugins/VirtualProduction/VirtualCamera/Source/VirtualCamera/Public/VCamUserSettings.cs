namespace AssetTool
{
    [JsonAsset("VirtualCameraUserSettings")]
    public class UVirtualCameraUserSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}