namespace AssetTool
{
    [StructSerializable("ColorMaterialInput")]
    public class FColorMaterialInput : FMaterialInput<FColor>, ITransferible
    {
        public new const string StructName = "ColorMaterialInput";

        public FBool UseConstant;
        public FColor Constant = new();

        [Location("bool FColorMaterialInput::Serialize(FArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref UseConstant);
            Constant.Move(transfer);
            return this;
        }
    }
}
