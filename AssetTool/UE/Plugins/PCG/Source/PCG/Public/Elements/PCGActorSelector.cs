namespace AssetTool
{
    public class FPCGSelectionKey : ITransferible
    {
        public UScriptStruct ScriptStruct;

        [Location("FArchive& operator<<(FArchive& Ar, FPCGSelectionKey& Key)")]
        public ITransferible Move2(Transfer transfer)
        {
            ScriptStruct ??= new();
            ScriptStruct.SerializeTaggedProperties(transfer);
            return this;
        }
    }
}
