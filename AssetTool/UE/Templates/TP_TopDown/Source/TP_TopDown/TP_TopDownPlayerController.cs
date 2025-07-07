namespace AssetTool
{
    [JsonAsset("TP_TopDownPlayerController")]
    public class ATP_TopDownPlayerController : APlayerController
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}