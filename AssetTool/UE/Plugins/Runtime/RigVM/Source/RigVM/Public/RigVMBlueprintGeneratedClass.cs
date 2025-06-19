namespace AssetTool
{
    [JsonAsset("RigVMBlueprintGeneratedClass")]
    public class URigVMBlueprintGeneratedClass : UBlueprintGeneratedClass
    {
        public URigVM VM;
        public FRigVMGraphFunctionStore GraphFunctionStore;

        [Location("void URigVMBlueprintGeneratedClass::Serialize(FArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);

            if (!transfer.Supports.RigVMGeneratedClass)
                return this;

            transfer.MoveObject(ref VM);
            transfer.Move(ref GraphFunctionStore);

            return this;
        }

        public ITransferible UBlueprintGeneratedClassMove(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}