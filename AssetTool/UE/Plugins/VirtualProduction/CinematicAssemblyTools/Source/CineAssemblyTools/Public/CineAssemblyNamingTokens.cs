namespace AssetTool
{
    [JsonAsset("CineAssemblyNamingTokensContext")]
    public class UCineAssemblyNamingTokensContext : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CineAssemblyNamingTokens")]
    public class UCineAssemblyNamingTokens : UNamingTokens
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}