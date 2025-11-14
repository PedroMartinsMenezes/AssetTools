namespace AssetTool
{
    [JsonAsset("ReimportHairStrandsFactory")]
    public class UReimportHairStrandsFactory : UHairStrandsFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}