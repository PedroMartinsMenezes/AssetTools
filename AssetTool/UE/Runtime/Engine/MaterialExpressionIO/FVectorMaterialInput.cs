namespace AssetTool
{
    [StructSerializable("VectorMaterialInput")]
    public class FVectorMaterialInput : FMaterialInput<FVector3f>, ITransferible
    {
        public new const string StructName = "VectorMaterialInput";

        public FBool UseConstant;
        public FVector3f Constant = new();

        [Location("bool FVectorMaterialInput::Serialize(FArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref UseConstant);
            Constant.Move(transfer);
            return this;
        }
    }
}
