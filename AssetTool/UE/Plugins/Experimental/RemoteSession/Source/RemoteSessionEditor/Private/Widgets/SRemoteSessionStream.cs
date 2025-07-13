namespace AssetTool
{
    [JsonAsset("RemoteSessionStreamSettings")]
    public class URemoteSessionStreamSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("RemoteSessionStreamWidgetUserData")]
    public class URemoteSessionStreamWidgetUserData : UAssetUserData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}