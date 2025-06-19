namespace AssetTool
{
    [JsonAsset("PCGPrintGrammarSettings")]
    public class UPCGPrintGrammarSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}