namespace AssetTool
{
    [JsonAsset("ChaosCacheManager")]
    public class AChaosCacheManager : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ChaosCachePlayer")]
    public class AChaosCachePlayer : AChaosCacheManager
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}