namespace AssetTool
{
    [Location("bool FColorMaterialInput::Serialize(FArchive& Ar)")]
    public class FColorMaterialInput : TMaterialInput<FColor>
    {
        public new const string StructName = "ColorMaterialInput";

        public FBool bUseConstantValue;
        public FColor Constant;

        public FColorMaterialInput() { }

        public FColorMaterialInput(BinaryReader reader)
        {
            var transfer = GlobalObjects.Transfer;
            ReadExpressionInput(reader);

            transfer.Move(ref bUseConstantValue);
            Constant = new FColor(reader);
        }

        public new void Write(BinaryWriter writer)
        {
            var transfer = GlobalObjects.Transfer;
            WriteReadExpressionInput(writer);

            transfer.Move(ref bUseConstantValue);
            Constant.Write(writer);
        }
    }
}
