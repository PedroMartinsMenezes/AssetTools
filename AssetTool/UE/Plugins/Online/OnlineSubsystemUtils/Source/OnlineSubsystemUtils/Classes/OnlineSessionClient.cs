namespace AssetTool
{
    [JsonAsset("OnlineSessionClient")]
    public class UOnlineSessionClient : UOnlineSession
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}