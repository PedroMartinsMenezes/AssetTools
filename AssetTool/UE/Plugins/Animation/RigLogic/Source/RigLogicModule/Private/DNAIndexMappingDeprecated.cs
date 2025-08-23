namespace AssetTool
{
    [JsonAsset("DNAIndexMapping")]
    public class UDEPRECATED_DNAIndexMapping : UAssetUserData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}