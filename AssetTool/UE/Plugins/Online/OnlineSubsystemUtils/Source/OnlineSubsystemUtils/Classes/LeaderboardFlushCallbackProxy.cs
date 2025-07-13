namespace AssetTool
{
    [JsonAsset("LeaderboardFlushCallbackProxy")]
    public class ULeaderboardFlushCallbackProxy : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}