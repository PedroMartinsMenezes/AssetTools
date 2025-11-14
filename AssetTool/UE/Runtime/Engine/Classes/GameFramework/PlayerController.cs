namespace AssetTool
{
    [JsonAsset("PlayerController")]
    public class APlayerController : AController
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}