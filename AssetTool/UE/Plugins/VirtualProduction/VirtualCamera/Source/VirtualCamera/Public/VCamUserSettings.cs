namespace AssetTool
{
    [JsonAsset("VirtualCameraUserSettings")]
    public class UVirtualCameraUserSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}