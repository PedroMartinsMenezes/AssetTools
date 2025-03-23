namespace AssetTool
{
    [JsonAsset("CommonGameViewportClient")]
    public class UCommonGameViewportClient : UGameViewportClient
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}