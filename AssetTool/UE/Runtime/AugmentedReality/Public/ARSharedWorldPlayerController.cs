namespace AssetTool
{
    [JsonAsset("ARSharedWorldPlayerController")]
    public class AARSharedWorldPlayerController : APlayerController
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}