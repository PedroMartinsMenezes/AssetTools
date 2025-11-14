namespace AssetTool
{
    [JsonAsset("WebSocketClient")]
    public class UWebSocketClient : UIPClient
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}