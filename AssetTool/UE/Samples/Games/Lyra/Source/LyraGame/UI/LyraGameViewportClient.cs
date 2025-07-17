namespace AssetTool
{
    [JsonAsset("LyraGameViewportClient")]
    public class ULyraGameViewportClient : UCommonGameViewportClient
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}