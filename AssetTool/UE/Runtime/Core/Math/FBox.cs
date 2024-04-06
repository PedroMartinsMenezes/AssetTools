namespace AssetTool
{
    public class FBox
    {
        public const string StructName = "Box";

        public FVector Min;
        public FVector Max;
        public byte IsValid;

        public FBox Read(BinaryReader reader)
        {
            Min = new FVector().Read(reader);
            Max = new FVector().Read(reader);
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
