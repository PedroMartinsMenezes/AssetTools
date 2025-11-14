namespace AssetTool
{
    [JsonAsset("GameViewportClient")]
    public class UGameViewportClient : UScriptViewportClient
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}