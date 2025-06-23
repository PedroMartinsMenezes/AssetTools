namespace AssetTool
{
    [JsonAsset("ControlRigBlueprintGeneratedClass")]
    public class UControlRigBlueprintGeneratedClass : URigVMBlueprintGeneratedClass
    {
        public FRigVMGraphFunctionStore GraphFunctionStore2;
        public URigVM VM2 = new();

        [Location("void UControlRigBlueprintGeneratedClass::Serialize(FArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
            UBlueprintGeneratedClassMove(transfer);

            if (!transfer.Supports.SwitchedToRigVM)
                return this;

            VM2.Move(transfer);

            if (!transfer.Supports.StoreFunctionsInGeneratedClass)
                return this;

            transfer.Move(ref GraphFunctionStore2);

            return this;
        }
    }
}