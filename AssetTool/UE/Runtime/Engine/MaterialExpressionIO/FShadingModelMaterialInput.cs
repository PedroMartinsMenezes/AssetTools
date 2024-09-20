namespace AssetTool
{
    [Location("bool FShadingModelMaterialInput::Serialize(FArchive& Ar)")]
    public class FShadingModelMaterialInput : FMaterialInput<UInt32>
    {
        public new const string StructName = "ShadingModelMaterialInput";

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
