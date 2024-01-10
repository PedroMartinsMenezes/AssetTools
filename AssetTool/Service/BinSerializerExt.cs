using AssetTool.Model;
using AssetTool.Model.Const;

namespace AssetTool
{
    public static class BinSerializerExt
    {
        #region Scalar
        public static FString ReadFString(this BinaryReader reader) => reader.Read(new FString());

        public static void Read(this BinaryReader reader, ref bool item) => item = reader.ReadInt32() == 1;

        public static void Read(this BinaryReader reader, ref char item) => item = reader.ReadChar();

        public static void Read(this BinaryReader reader, ref byte item) => item = reader.ReadByte();

        public static void Read(this BinaryReader reader, ref Int16 item) => item = reader.ReadInt16();

        public static void Read(this BinaryReader reader, ref UInt16 item) => item = reader.ReadUInt16();

        public static void Read(this BinaryReader reader, ref Int32 item) => item = reader.ReadInt32();

        public static void Read(this BinaryReader reader, ref UInt32 item) => item = reader.ReadUInt32();

        public static void Read(this BinaryReader reader, ref Int64 item) => item = reader.ReadInt64();

        public static void Read(this BinaryReader reader, ref UInt64 item) => item = reader.ReadUInt64();
        #endregion

        #region List
        public static void Read(this BinaryReader reader, List<char> list) =>
            Enumerable.Range(0, reader.ReadInt32()).ToList().ForEach(x => list.Add(reader.ReadChar()));

        public static void Read(this BinaryReader reader, List<byte> list) =>
            Enumerable.Range(0, reader.ReadInt32()).ToList().ForEach(x => list.Add(reader.ReadByte()));

        public static void Read(this BinaryReader reader, List<Int16> list) =>
            Enumerable.Range(0, reader.ReadInt32()).ToList().ForEach(x => list.Add(reader.ReadInt16()));

        public static void Read(this BinaryReader reader, List<UInt16> list) =>
            Enumerable.Range(0, reader.ReadInt32()).ToList().ForEach(x => list.Add(reader.ReadUInt16()));

        public static void Read(this BinaryReader reader, List<Int32> list) =>
            Enumerable.Range(0, reader.ReadInt32()).ToList().ForEach(x => list.Add(reader.ReadInt32()));

        public static void Read(this BinaryReader reader, List<UInt32> list) =>
            Enumerable.Range(0, reader.ReadInt32()).ToList().ForEach(x => list.Add(reader.ReadUInt32()));

        public static void Read(this BinaryReader reader, List<Int64> list) =>
            Enumerable.Range(0, reader.ReadInt32()).ToList().ForEach(x => list.Add(reader.ReadInt64()));

        public static void Read(this BinaryReader reader, List<UInt64> list) =>
            Enumerable.Range(0, reader.ReadInt32()).ToList().ForEach(x => list.Add(reader.ReadUInt64()));
        #endregion

        #region Object
        public static void ReadObject(this BinaryReader reader, string type, AssetObject item)
        {
            if (type == Consts.MetaData)
                reader.Read(item.Get<UMetadata>());
            else if (type == Consts.UserDefinedStruct)
                reader.Read(item.Get<UUserDefinedStruct>());
            else if (type == Consts.UserDefinedStructEditorData)
                reader.Read(item.Get<UUserDefinedStructEditorData>());
            else
                throw new InvalidOperationException($"Type not supported: {type}");
        }
        public static void WriteObject(this BinaryWriter writer, string type, AssetObject item)
        {
            if (type == Consts.MetaData)
                writer.Write((UMetadata)item.Obj);
            else if (type == Consts.UserDefinedStruct)
                writer.Write((UUserDefinedStruct)item.Obj);
            else if (type == Consts.UserDefinedStructEditorData)
                writer.Write((UUserDefinedStructEditorData)item.Obj);
            else
                throw new InvalidOperationException($"Type not supported: {type}");
        }
        #endregion
    }
}
