namespace AssetTool
{
    public class FRigConnectionRuleStash : ITransferable
    {
        public FString ScriptStructPath;
        public FString ExportedText;

        [Location("void FRigConnectionRuleStash::Load(FArchive& Ar)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref ScriptStructPath);
            transfer.Move(ref ExportedText);
            return this;
        }
    }
}