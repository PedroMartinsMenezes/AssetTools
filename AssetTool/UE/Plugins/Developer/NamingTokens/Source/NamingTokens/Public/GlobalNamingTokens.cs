namespace AssetTool
{
    [JsonAsset("GlobalNamingTokens")]
    public class UGlobalNamingTokens : UNamingTokens
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}