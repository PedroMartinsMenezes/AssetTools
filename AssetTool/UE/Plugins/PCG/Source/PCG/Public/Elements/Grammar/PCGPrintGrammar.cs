namespace AssetTool
{
    [JsonAsset("PCGPrintGrammarSettings")]
    public class UPCGPrintGrammarSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}