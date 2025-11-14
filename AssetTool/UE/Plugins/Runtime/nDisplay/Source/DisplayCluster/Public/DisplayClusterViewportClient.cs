namespace AssetTool
{
    [JsonAsset("DisplayClusterViewportClient")]
    public class UDisplayClusterViewportClient : UGameViewportClient
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}