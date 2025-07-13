namespace AssetTool
{
    [JsonAsset("BuoyancyManager")]
    public class ABuoyancyManager : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}