namespace AssetTool
{
    [JsonAsset("Controller")]
    public class AController : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}