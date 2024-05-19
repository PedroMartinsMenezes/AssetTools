namespace AssetTool
{
    [Location("bool FColorMaterialInput::Serialize(FArchive& Ar)")]
    public class FColorMaterialInput : TMaterialInput<FColor>
    {
        public new const string StructName = "ColorMaterialInput";

        public FBool bUseConstantValue;
        public FColor Constant = new();

        public override FExpressionInput Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref bUseConstantValue);
            Constant.Move(transfer);
            return this;
        }
    }
}
