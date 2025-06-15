namespace AssetTool
{
    [JsonAsset("AbstractNavData")]
    public class AAbstractNavData : ANavigationData
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}