namespace AssetTool
{
    [JsonAsset("BuoyancyManager")]
    public class ABuoyancyManager : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}