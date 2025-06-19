namespace AssetTool
{
    [JsonAsset("GameViewportClient")]
    public class UGameViewportClient : UScriptViewportClient
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}