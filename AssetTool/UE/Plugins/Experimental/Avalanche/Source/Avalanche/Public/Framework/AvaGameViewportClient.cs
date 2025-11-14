namespace AssetTool
{
    [JsonAsset("AvaGameViewportClient")]
    public class UAvaGameViewportClient : UGameViewportClient
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}