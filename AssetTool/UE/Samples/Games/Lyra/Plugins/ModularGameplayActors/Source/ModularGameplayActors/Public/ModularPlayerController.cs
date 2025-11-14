namespace AssetTool
{
    [JsonAsset("ModularPlayerController")]
    public class AModularPlayerController : APlayerController
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}