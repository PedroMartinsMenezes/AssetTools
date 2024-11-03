namespace AssetTool
{
    public class FRigVMExternalVariable : ITransferible
    {
        public FName Name;
        public FName TypeName;
        public FSoftObjectPath TypeObjectPath = new();
        public FBool bIsArray;
        public FBool bIsPublic;
        public FBool bIsReadOnly;
        public Int32 Size;

        [Location("inline FArchive& operator<<(FArchive& Ar, FRigVMExternalVariableDef& Variable)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Name);
            transfer.Move(ref TypeName);
            TypeObjectPath.Move(transfer);
            transfer.Move(ref bIsArray);
            transfer.Move(ref bIsPublic);
            transfer.Move(ref bIsReadOnly);
            transfer.Move(ref Size);
            return this;
        }
    }
}
