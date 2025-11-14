namespace AssetTool
{
    public class FPCGSelectionKey : ITransferable
    {
        public UScriptStruct ScriptStruct;

        [Location("FArchive& operator<<(FArchive& Ar, FPCGSelectionKey& Key)")]
        public ITransferable Move(Transfer transfer)
        {
            ScriptStruct ??= new();
            ScriptStruct.SerializeTaggedProperties(transfer);
            return this;
        }
    }
}
