namespace AssetTool
{
    [JsonAsset("CommonPlayerController")]
    public class ACommonPlayerController : AModularPlayerController
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}