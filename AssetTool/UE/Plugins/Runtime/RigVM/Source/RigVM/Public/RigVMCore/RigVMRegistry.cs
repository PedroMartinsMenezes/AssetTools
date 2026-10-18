namespace AssetTool
{
    public class FRigVMRegistry_NoLock : ITransferable
    {
        public List<FPackageIndex> AllowedClasses;
        // types
        public List<FTypeInfo> Types;
        // factories
        public List<RigVMFactory> Factories;
        // functions
        public List<FRigVMFunction> Functions;

        [Location("void FRigVMRegistry_NoLock::Serialize_NoLock(FArchive& Ar)")]
        public virtual ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref AllowedClasses);
            //types
            transfer.Move(ref Types);
            // factories
            transfer.Move(ref Factories);
            // functions
            transfer.Move(ref Functions);
            return this;
        }

        public class FTypeInfo : ITransferable
        {
            public FRigVMTemplateArgumentType Type;

            [Location("void FRigVMRegistry_NoLock::FTypeInfo::Serialize_NoLock(FArchive& Ar)")]
            public ITransferable Move(Transfer transfer)
            {
                transfer.Move(ref Type);
                return this;
            }
        }

        [NonUnreal]
        public class RigVMFactory : ITransferable
        {
            public UScriptStruct FactoryScriptStruct;
            public List<FRigVMTemplateArgumentInfo> FlattenedArguments;

            public ITransferable Move(Transfer transfer)
            {
                transfer.Move(ref FactoryScriptStruct);
                transfer.Move(ref FlattenedArguments);
                return this;
            }
        }
    }
}
