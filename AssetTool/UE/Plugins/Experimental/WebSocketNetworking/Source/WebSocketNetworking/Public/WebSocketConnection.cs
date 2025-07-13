namespace AssetTool
{
    [JsonAsset("WebSocketConnection")]
    public class UWebSocketConnection : UNetConnection
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}