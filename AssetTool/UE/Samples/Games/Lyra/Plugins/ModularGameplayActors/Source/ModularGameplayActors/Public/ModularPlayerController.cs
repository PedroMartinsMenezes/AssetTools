namespace AssetTool
{
    [JsonAsset("ModularPlayerController")]
    public class AModularPlayerController : APlayerController
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}