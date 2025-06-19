namespace AssetTool
{
    [JsonAsset("PlayerController")]
    public class APlayerController : AController
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}