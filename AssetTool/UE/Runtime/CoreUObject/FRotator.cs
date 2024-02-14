namespace AssetTool
{
    [Location("operator<<(FArchive& Ar, TRotator<double>& R)")]
    public class FRotator
    {
        public double Pitch;
        public double Yaw;
        public double Roll;

        public const string StructName = "Rotator";

        public FRotator() { }

        public FRotator(BinaryReader reader)
        {
            Pitch = reader.ReadDouble();
            Yaw = reader.ReadDouble();
            Roll = reader.ReadDouble();
        }

        public void Write(BinaryWriter writer)
        {
            writer.Write(Pitch);
            writer.Write(Yaw);
            writer.Write(Roll);
        }
    }
}
