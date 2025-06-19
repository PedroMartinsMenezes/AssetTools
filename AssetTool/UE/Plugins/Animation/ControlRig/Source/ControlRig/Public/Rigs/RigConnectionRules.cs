namespace AssetTool
{
    public class FRigConnectionRuleStash : ITransferible
    {
        public FString ScriptStructPath;
        public FString ExportedText;

        [Location("void FRigConnectionRuleStash::Load(FArchive& Ar)")]
        public ITransferible Move2(Transfer transfer)
        {
            transfer.Move(ref ScriptStructPath);
            transfer.Move(ref ExportedText);
            return this;
        }
    }
}