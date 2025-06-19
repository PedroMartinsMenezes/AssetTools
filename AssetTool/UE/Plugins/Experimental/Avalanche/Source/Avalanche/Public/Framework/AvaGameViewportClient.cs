namespace AssetTool
{
    [JsonAsset("AvaGameViewportClient")]
    public class UAvaGameViewportClient : UGameViewportClient
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}