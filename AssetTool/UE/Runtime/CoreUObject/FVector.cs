namespace AssetTool
{
    public class FVector
    {
        public double X;
        public double Y;
        public double Z;

        public const string StructName = "Vector";

        public FVector() { }

        public FVector(BinaryReader reader)
        {
            X = reader.ReadDouble();
            Y = reader.ReadDouble();
            Z = reader.ReadDouble();
        }

        public void Write(BinaryWriter writer)
        {
            writer.Write(X);
            writer.Write(Y);
            writer.Write(Z);
        }
    }
}
