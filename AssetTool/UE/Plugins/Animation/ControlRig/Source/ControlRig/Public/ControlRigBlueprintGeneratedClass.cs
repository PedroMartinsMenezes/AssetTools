namespace AssetTool
{
    [JsonAsset("ControlRigBlueprintGeneratedClass")]
    public class UControlRigBlueprintGeneratedClass : URigVMBlueprintGeneratedClass
    {
        public new FRigVMGraphFunctionStore GraphFunctionStore;
        public new URigVM VM = new();

        [Location("void UControlRigBlueprintGeneratedClass::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            UBlueprintGeneratedClassMove(transfer);

            if (!transfer.Supports.SwitchedToRigVM)
                return this;

            VM.Move(transfer);

            if (!transfer.Supports.StoreFunctionsInGeneratedClass)
                return this;

            transfer.Move(ref GraphFunctionStore);

            return this;
        }
    }
}