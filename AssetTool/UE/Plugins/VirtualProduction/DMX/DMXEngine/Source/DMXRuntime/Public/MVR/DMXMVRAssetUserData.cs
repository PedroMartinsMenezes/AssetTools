namespace AssetTool
{
    [JsonAsset("DMXMVRAssetUserData")]
    public class UDMXMVRAssetUserData : UAssetUserData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}