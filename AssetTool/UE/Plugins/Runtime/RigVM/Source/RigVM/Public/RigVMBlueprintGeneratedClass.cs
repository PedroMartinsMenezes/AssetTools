namespace AssetTool
{
    [JsonAsset("RigVMBlueprintGeneratedClass")]
    public class URigVMBlueprintGeneratedClass : UBlueprintGeneratedClass
    {
        public URigVM VM;
        public FRigVMGraphFunctionStore GraphFunctionStore;

        [Location("void URigVMBlueprintGeneratedClass::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);

            if (!Supports.RigVMGeneratedClass)
                return this;

            transfer.MoveObject(ref VM);
            transfer.Move(ref GraphFunctionStore);

            return this;
        }

        public UObject UBlueprintGeneratedClassMove(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}