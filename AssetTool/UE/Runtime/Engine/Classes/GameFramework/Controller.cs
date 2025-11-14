namespace AssetTool
{
    [JsonAsset("Controller")]
    public class AController : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}