namespace AssetTool
{
    [JsonAsset("OnlineEngineInterface")]
    public class UOnlineEngineInterface : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}