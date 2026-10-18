namespace AssetTool
{
    public enum ERigVMPinDirection : byte
    {
        Input,
        Output,
        IO,
        Visible,
        Hidden,
        Invalid
    }

    public class FRigVMFunction : ITransferable
    {
        public FString Name;
        public UScriptStruct Struct;
        public UScriptStruct FactoryStruct;
        public List<FRigVMFunctionArgument> Arguments;

        [Location("void FRigVMFunction::Serialize_NoLock(FArchive& Ar, FRigVMRegistryHandle& InRegistry)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Name);
            transfer.Move(ref Struct);
            transfer.Move(ref FactoryStruct);
            transfer.Move(ref Arguments);
            return this;
        }
    }

    public class FRigVMFunctionArgument : ITransferable
    {
        public FString Name;
        public FString Type;
        public ERigVMFunctionArgumentDirection Direction;

        [Location("void FRigVMFunctionArgument::Serialize_NoLock(FArchive& Ar)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Name);
            transfer.Move(ref Type);
            transfer.MoveEnum(ref Direction);
            return this;
        }
    }

    public enum ERigVMFunctionArgumentDirection : uint32
    {
        Input,
        Output,
        Invalid
    }
}
