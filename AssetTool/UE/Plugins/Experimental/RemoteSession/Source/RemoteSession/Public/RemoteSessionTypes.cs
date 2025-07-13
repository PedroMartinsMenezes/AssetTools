namespace AssetTool
{
    [JsonAsset("RemoteSessionSettings")]
    public class URemoteSessionSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}