namespace AssetTool
{
    [Location("bool FVectorMaterialInput::Serialize(FArchive& Ar)")]
    public class FVectorMaterialInput : FMaterialInput<FVector3f>
    {
        public new const string StructName = "VectorMaterialInput";

        public FBool UseConstant;
        public FVector3f Constant = new();

        public override FExpressionInput Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref UseConstant);
            Constant.Move(transfer);
            return this;
        }
    }
}
