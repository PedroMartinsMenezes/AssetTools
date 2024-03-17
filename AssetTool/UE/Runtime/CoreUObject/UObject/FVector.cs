namespace AssetTool
{
    public class FVector
    {
        public double X;
        public double Y;
        public double Z;

        public FVector Read(BinaryReader reader)
        {
            X = reader.ReadDouble();
            Y = reader.ReadDouble();
            Z = reader.ReadDouble();
            return this;
        }
        public void Write(BinaryWriter writer)
        {
            writer.Write(X);
            writer.Write(Y);
            writer.Write(Z);
        }
    }
}
