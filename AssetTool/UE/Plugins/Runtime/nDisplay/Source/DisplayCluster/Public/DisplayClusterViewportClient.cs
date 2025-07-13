namespace AssetTool
{
    [JsonAsset("DisplayClusterViewportClient")]
    public class UDisplayClusterViewportClient : UGameViewportClient
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}