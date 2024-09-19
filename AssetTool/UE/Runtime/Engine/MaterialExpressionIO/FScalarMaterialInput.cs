namespace AssetTool
{
    [Location("bool FScalarMaterialInput::Serialize(FArchive& Ar)")]
    public class FScalarMaterialInput : FMaterialInput<float>
    {
        public new const string StructName = "ScalarMaterialInput";

        public FBool UseConstant;
        public float Constant;

        public override FExpressionInput Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref UseConstant);
            transfer.Move(ref Constant);
            return this;
        }
    }
}
