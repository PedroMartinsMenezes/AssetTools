namespace AssetTool
{
    [JsonAsset("GameViewportClient")]
    public class UGameViewportClient : UScriptViewportClient
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}