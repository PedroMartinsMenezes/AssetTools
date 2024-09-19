namespace AssetTool
{
    [Location("bool FStrataMaterialInput::Serialize(FArchive& Ar)")]
    public class FStrataMaterialInput : FMaterialInput<UInt32>
    {
        public new const string StructName = "StrataMaterialInput";

        public FBool UseConstant;
        public UInt32 Constant = new();

        public override FExpressionInput Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref UseConstant);
            transfer.Move(ref Constant);
            return this;
        }
    }
}
