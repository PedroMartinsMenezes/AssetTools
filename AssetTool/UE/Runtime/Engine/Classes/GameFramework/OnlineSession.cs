namespace AssetTool
{
    [JsonAsset("OnlineSession")]
    public class UOnlineSession : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}