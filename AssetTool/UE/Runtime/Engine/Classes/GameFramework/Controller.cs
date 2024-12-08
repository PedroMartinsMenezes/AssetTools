namespace AssetTool
{
    [JsonAsset("Controller")]
    public class AController : AActor
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}