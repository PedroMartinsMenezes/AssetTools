namespace AssetTool
{
    [JsonAsset("NamingTokensFactory")]
    public class UNamingTokensFactory : UFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}