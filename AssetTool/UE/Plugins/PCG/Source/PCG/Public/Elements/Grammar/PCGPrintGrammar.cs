namespace AssetTool
{
    [JsonAsset("PCGPrintGrammarSettings")]
    public class UPCGPrintGrammarSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}