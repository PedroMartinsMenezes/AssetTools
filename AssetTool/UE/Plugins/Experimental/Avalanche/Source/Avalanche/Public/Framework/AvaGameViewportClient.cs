namespace AssetTool
{
    [JsonAsset("AvaGameViewportClient")]
    public class UAvaGameViewportClient : UGameViewportClient
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}