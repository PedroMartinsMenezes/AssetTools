namespace AssetTool
{
    [JsonAsset("OnlineSessionClient")]
    public class UOnlineSessionClient : UOnlineSession
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}