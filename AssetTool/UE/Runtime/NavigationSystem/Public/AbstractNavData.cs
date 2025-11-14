namespace AssetTool
{
    [JsonAsset("AbstractNavData")]
    public class AAbstractNavData : ANavigationData
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}