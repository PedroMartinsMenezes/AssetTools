namespace AssetTool
{
    [JsonAsset("CommonPlayerController")]
    public class ACommonPlayerController : AModularPlayerController
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}