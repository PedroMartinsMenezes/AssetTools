namespace AssetTool
{
    [JsonAsset("LiveLinkPreviewController")]
    public class ULiveLinkPreviewController : UPersonaPreviewSceneController
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}