namespace AssetTool
{
    [JsonAsset("WebSocketClient")]
    public class UWebSocketClient : UIPClient
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}