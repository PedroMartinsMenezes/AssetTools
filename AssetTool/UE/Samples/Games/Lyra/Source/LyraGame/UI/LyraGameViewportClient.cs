namespace AssetTool
{
    [JsonAsset("LyraGameViewportClient")]
    public class ULyraGameViewportClient : UCommonGameViewportClient
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}