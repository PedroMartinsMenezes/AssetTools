namespace AssetTool
{
    [JsonAsset("RigVMBlueprintGeneratedClass")]
    public class URigVMBlueprintGeneratedClass : UBlueprintGeneratedClass
    {
        public URigVM VM;
        public FRigVMGraphFunctionStore GraphFunctionStore;

        [Location("void URigVMBlueprintGeneratedClass::Serialize(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            if (transfer.GlobalObjects.CurrentObject.ObjectFlags.HasFlag(EObjectFlags.RF_ClassDefaultObject))
            {
                return this;
            }

            if (!transfer.Supports.RigVMGeneratedClass)
                return this;

            transfer.Move(ref VM);
            transfer.Move(ref GraphFunctionStore);

            return this;
        }

        public ITransferable UBlueprintGeneratedClassMove(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}