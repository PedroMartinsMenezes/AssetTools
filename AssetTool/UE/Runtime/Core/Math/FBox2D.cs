namespace AssetTool
{
    public class FBox2D
    {
        public FVector2D Min;
        public FVector2D Max;
        public byte IsValid;

        public const string StructName = "Box2D";

        public FBox2D Read(BinaryReader reader)
        {
            Min = new FVector2D(reader);
            Max = new FVector2D(reader);
            reader.Read(ref IsValid);
            return this;
        }

        public void Write(BinaryWriter writer)
        {
            Min.Write(writer);
            Max.Write(writer);
            writer.Write(IsValid);
        }
    }
}
