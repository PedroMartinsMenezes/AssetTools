namespace AssetTool
{
    [JsonAsset("RemoteSessionStreamSettings")]
    public class URemoteSessionStreamSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("RemoteSessionStreamWidgetUserData")]
    public class URemoteSessionStreamWidgetUserData : UAssetUserData
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}