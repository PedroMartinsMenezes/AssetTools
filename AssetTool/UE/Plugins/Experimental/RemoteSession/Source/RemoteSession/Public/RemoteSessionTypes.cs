namespace AssetTool
{
    [JsonAsset("RemoteSessionSettings")]
    public class URemoteSessionSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}