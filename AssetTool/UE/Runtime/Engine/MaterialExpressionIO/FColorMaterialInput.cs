namespace AssetTool
{
    [Location("bool FColorMaterialInput::Serialize(FArchive& Ar)")]
    public class FColorMaterialInput : FMaterialInput<FColor>
    {
        public new const string StructName = "ColorMaterialInput";

        public FBool UseConstant;
        public FColor Constant = new();

        public override FExpressionInput Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref UseConstant);
            Constant.Move(transfer);
            return this;
        }
    }
}
