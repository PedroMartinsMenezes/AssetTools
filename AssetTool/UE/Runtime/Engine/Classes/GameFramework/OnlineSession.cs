namespace AssetTool
{
    [JsonAsset("OnlineSession")]
    public class UOnlineSession : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}