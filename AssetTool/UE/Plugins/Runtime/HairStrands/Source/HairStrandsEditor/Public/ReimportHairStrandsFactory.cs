namespace AssetTool
{
    [JsonAsset("ReimportHairStrandsFactory")]
    public class UReimportHairStrandsFactory : UHairStrandsFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}