namespace AssetTool
{
    [JsonAsset("CommonGameViewportClient")]
    public class UCommonGameViewportClient : UGameViewportClient
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}