namespace AssetTool
{
    [Location("FArchive& operator<<(FArchive& Ar, TVector2<double>& V)")]
    public class FVector2D
    {
        public double X;
        public double Y;

        public const string StructName = "Vector2D";

        public FVector2D() { }

        public FVector2D(BinaryReader reader)
        {
            X = reader.ReadDouble();
            Y = reader.ReadDouble();
        }

        public void Write(BinaryWriter writer)
        {
            writer.Write(X);
            writer.Write(Y);
        }
    }
}
