namespace AssetTool
{
    public class FExpressionInput
    {
        public const string StructName = "ExpressionInput";

        public UInt64 Expression;
        public Int32 OutputIndex;
        public FName InputName;
        public Int32 Mask;
        public Int32 MaskR;
        public Int32 MaskG;
        public Int32 MaskB;
        public Int32 MaskA;

        public FExpressionInput() { }

        public FExpressionInput(BinaryReader reader)
        {
            ReadExpressionInput(reader);
        }

        public void Write(BinaryWriter writer)
        {
            WriteReadExpressionInput(writer);
        }

        public void ReadExpressionInput(BinaryReader reader)
        {
            reader.Read(ref Expression);
            reader.Read(ref InputName);
            reader.Read(ref Mask);
            reader.Read(ref MaskR);
            reader.Read(ref MaskG);
            reader.Read(ref MaskB);
            reader.Read(ref MaskA);
        }

        public void WriteReadExpressionInput(BinaryWriter writer)
        {
            writer.Write(Expression);
            writer.Write(InputName);
            writer.Write(Mask);
            writer.Write(MaskR);
            writer.Write(MaskG);
            writer.Write(MaskB);
            writer.Write(MaskA);
        }
    }
}
