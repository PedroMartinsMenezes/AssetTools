namespace AssetTool
{
    [JsonAsset("PersonaPreviewSceneDefaultController")]
    public class UPersonaPreviewSceneDefaultController : UPersonaPreviewSceneController
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}