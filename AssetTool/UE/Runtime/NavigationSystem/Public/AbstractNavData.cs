namespace AssetTool
{
    [JsonAsset("AbstractNavData")]
    public class AAbstractNavData : ANavigationData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}