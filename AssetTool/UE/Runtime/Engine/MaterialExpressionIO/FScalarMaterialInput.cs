namespace AssetTool
{
    [StructSerializable("ScalarMaterialInput")]
    public class FScalarMaterialInput : FMaterialInput<float>, ITransferible
    {
        public new const string StructName = "ScalarMaterialInput";

        public FBool UseConstant;
        public float Constant;

        [Location("bool FScalarMaterialInput::Serialize(FArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref UseConstant);
            transfer.Move(ref Constant);
            return this;
        }
    }
}
