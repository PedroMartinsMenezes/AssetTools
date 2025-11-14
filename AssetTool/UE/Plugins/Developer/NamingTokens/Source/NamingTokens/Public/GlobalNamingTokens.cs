namespace AssetTool
{
    [JsonAsset("GlobalNamingTokens")]
    public class UGlobalNamingTokens : UNamingTokens
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}