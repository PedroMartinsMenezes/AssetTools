namespace AssetTool
{
    [JsonAsset("OnlineEngineInterface")]
    public class UOnlineEngineInterface : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}