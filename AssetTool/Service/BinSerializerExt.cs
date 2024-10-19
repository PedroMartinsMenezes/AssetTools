namespace AssetTool
{
    public static class BinSerializerExt
    {
        #region Scalar Read
        public static bool Read(this BinaryReader reader, ref bool item) => item = reader.ReadInt32() == 1;

        public static sbyte Read(this BinaryReader reader, ref sbyte item) => item = reader.ReadSByte();

        public static byte Read(this BinaryReader reader, ref byte item) => item = reader.ReadByte();

        public static Int16 Read(this BinaryReader reader, ref Int16 item) => item = reader.ReadInt16();

        public static UInt16 Read(this BinaryReader reader, ref UInt16 item) => item = reader.ReadUInt16();

        public static Int32 Read(this BinaryReader reader, ref Int32 item) => item = reader.ReadInt32();

        public static UInt32 Read(this BinaryReader reader, ref UInt32 item) => item = reader.ReadUInt32();

        public static Int64 Read(this BinaryReader reader, ref Int64 item) => item = reader.ReadInt64();

        public static UInt64 Read(this BinaryReader reader, ref UInt64 item) => item = reader.ReadUInt64();

        public static float Read(this BinaryReader reader, ref float item) => item = reader.ReadSingle();

        public static double Read(this BinaryReader reader, ref double item) => item = reader.ReadDouble();
        #endregion

        #region Scalar Write
        public static bool Write(this BinaryWriter writer, ref bool item) { writer.Write(item ? 1 : 0); return item; }

        public static sbyte Write(this BinaryWriter writer, ref sbyte item) { writer.Write(item); return item; }

        public static byte Write(this BinaryWriter writer, ref byte item) { writer.Write(item); return item; }

        public static Int16 Write(this BinaryWriter writer, ref Int16 item) { writer.Write(item); return item; }

        public static UInt16 Write(this BinaryWriter writer, ref UInt16 item) { writer.Write(item); return item; }

        public static Int32 Write(this BinaryWriter writer, ref Int32 item) { writer.Write(item); return item; }

        public static UInt32 Write(this BinaryWriter writer, ref UInt32 item) { writer.Write(item); return item; }

        public static Int64 Write(this BinaryWriter writer, ref Int64 item) { writer.Write(item); return item; }

        public static UInt64 Write(this BinaryWriter writer, ref UInt64 item) { writer.Write(item); return item; }

        public static float Write(this BinaryWriter writer, ref float item) { writer.Write(item); return item; }

        public static double Write(this BinaryWriter writer, ref double item) { writer.Write(item); return item; }
        #endregion
    }
}
