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
            ReadExpressionInput(reader);

            reader.Read(ref bUseConstantValue);
            Constant = new FColor(reader);
        }

        public void Write(BinaryWriter writer)
        {
            WriteReadExpressionInput(writer);

            writer.Write(bUseConstantValue);
            Constant.Write(writer);
        }
    }
}
