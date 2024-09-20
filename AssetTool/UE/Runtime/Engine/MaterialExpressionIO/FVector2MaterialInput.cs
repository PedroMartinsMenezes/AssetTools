namespace AssetTool
{
    [Location("bool FVector2MaterialInput::Serialize(FArchive& Ar)")]
    public class FVector2MaterialInput : FMaterialInput<FVector2f>
    {
        public new const string StructName = "Vector2MaterialInput";

        public FBool UseConstant;
        public FVector2f Constant = new();

        public override FExpressionInput Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref UseConstant);
            Constant.Move(transfer);
            return this;
        }
    }
}
