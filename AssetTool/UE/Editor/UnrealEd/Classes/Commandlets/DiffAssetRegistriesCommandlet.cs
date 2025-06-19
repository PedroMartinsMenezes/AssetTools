namespace AssetTool
{
    [JsonAsset("DiffAssetRegistriesCommandlet")]
    public class UDiffAssetRegistriesCommandlet : UCommandlet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}