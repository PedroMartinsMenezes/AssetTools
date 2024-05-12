namespace AssetTool
{
    public struct DMatrix4x4
    {
        public double M11;
        public double M12;
        public double M13;
        public double M14;
        public double M21;
        public double M22;
        public double M23;
        public double M24;
        public double M31;
        public double M32;
        public double M33;
        public double M34;
        public double M41;
        public double M42;
        public double M43;
        public double M44;

        public DMatrix4x4 Move(Transfer transfer)
        {
            if (transfer.IsReading)
                return Read(transfer.reader);
            else
                return Write(transfer.writer);
        }

        private DMatrix4x4 Read(BinaryReader reader)
        {
            if (Supports.UEVer(EUnrealEngineObjectUE5Version.LARGE_WORLD_COORDINATES))
            {
                M11 = reader.ReadDouble();
                M12 = reader.ReadDouble();
                M13 = reader.ReadDouble();
                M14 = reader.ReadDouble();
                M21 = reader.ReadDouble();
                M22 = reader.ReadDouble();
                M23 = reader.ReadDouble();
                M24 = reader.ReadDouble();
                M31 = reader.ReadDouble();
                M32 = reader.ReadDouble();
                M33 = reader.ReadDouble();
                M34 = reader.ReadDouble();
                M41 = reader.ReadDouble();
                M42 = reader.ReadDouble();
                M43 = reader.ReadDouble();
                M44 = reader.ReadDouble();
            }
            else
            {
                M11 = reader.ReadSingle();
                M12 = reader.ReadSingle();
                M13 = reader.ReadSingle();
                M14 = reader.ReadSingle();
                M21 = reader.ReadSingle();
                M22 = reader.ReadSingle();
                M23 = reader.ReadSingle();
                M24 = reader.ReadSingle();
                M31 = reader.ReadSingle();
                M32 = reader.ReadSingle();
                M33 = reader.ReadSingle();
                M34 = reader.ReadSingle();
                M41 = reader.ReadSingle();
                M42 = reader.ReadSingle();
                M43 = reader.ReadSingle();
                M44 = reader.ReadSingle();
            }
            return this;
        }

        private DMatrix4x4 Write(BinaryWriter writer)
        {
            if (Supports.UEVer(EUnrealEngineObjectUE5Version.LARGE_WORLD_COORDINATES))
            {
                writer.Write(M11);
                writer.Write(M12);
                writer.Write(M13);
                writer.Write(M14);
                writer.Write(M21);
                writer.Write(M22);
                writer.Write(M23);
                writer.Write(M24);
                writer.Write(M31);
                writer.Write(M32);
                writer.Write(M33);
                writer.Write(M34);
                writer.Write(M41);
                writer.Write(M42);
                writer.Write(M43);
                writer.Write(M44);
            }
            else
            {
                writer.Write((float)M11);
                writer.Write((float)M12);
                writer.Write((float)M13);
                writer.Write((float)M14);
                writer.Write((float)M21);
                writer.Write((float)M22);
                writer.Write((float)M23);
                writer.Write((float)M24);
                writer.Write((float)M31);
                writer.Write((float)M32);
                writer.Write((float)M33);
                writer.Write((float)M34);
                writer.Write((float)M41);
                writer.Write((float)M42);
                writer.Write((float)M43);
                writer.Write((float)M44);
            }
            return this;
        }
    }
}
