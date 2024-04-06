namespace AssetTool
{
    public class FQuat
    {
        public const string StructName = "Quat";

        public double X;
        public double Y;
        public double Z;
        public double W;

        public FQuat Read(BinaryReader reader)
        {
            X = reader.ReadDouble();
            Y = reader.ReadDouble();
            Z = reader.ReadDouble();
            W = reader.ReadDouble();
            return this;
        }
        public void Write(BinaryWriter writer)
        {
            writer.Write(X);
            writer.Write(Y);
            writer.Write(Z);
            writer.Write(W);
        }
    }
}
