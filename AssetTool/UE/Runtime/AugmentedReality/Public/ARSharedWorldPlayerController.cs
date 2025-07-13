namespace AssetTool
{
    [JsonAsset("ARSharedWorldPlayerController")]
    public class AARSharedWorldPlayerController : APlayerController
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}