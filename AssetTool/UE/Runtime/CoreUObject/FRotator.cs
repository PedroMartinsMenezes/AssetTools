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

            //byte[] PitchBytes = new byte[8];
            //byte[] YawBytes = new byte[8];
            //byte[] RollBytes = new byte[8];

            //reader.Read(PitchBytes, 0, 8);
            //reader.Read(YawBytes, 0, 8);
            //reader.Read(RollBytes, 0, 8);

            //Pitch = BitConverter.ToDouble(PitchBytes);
            //Yaw = BitConverter.ToDouble(YawBytes);
            //Roll = BitConverter.ToDouble(RollBytes);

            //Pitch = (Pitch == 0 && PitchBytes[7] == 0x80) ? -0.0 : Pitch;
            //Yaw = (Yaw == 0 && YawBytes[7] == 0x80) ? -0.0 : Yaw;
            //Roll = (Roll == 0 && RollBytes[7] == 0x80) ? -0.0 : Roll;
        }

        public void Write(BinaryWriter writer)
        {
            writer.Write(Pitch);
            writer.Write(Yaw);
            writer.Write(Roll);

            //writer.Write(BitConverter.GetBytes(Pitch));
            //writer.Write(BitConverter.GetBytes(Yaw));
            //writer.Write(BitConverter.GetBytes(Roll));
        }
    }
}
