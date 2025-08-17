namespace AssetTool
{
    [JsonAsset("NamingTokensFactory")]
    public class UNamingTokensFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}