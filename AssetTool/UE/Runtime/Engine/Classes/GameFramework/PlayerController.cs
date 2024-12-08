namespace AssetTool
{
    [JsonAsset("PlayerController")]
    public class APlayerController : AController
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}