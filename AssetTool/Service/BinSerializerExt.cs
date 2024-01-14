using AssetTool.Model;
using AssetTool.Model.Const;
using System.Collections;

namespace AssetTool
{
    public static class BinSerializerExt
    {
        #region Scalar
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

        #region AssetObject
        public static void ReadAssetObject(this BinaryReader reader, string type, AssetObject item)
        {
            if (type == Consts.MetaData)
                reader.Read(item.Get<UMetadata>());
            else if (type == Consts.UserDefinedStruct)
                reader.Read(item.Get<UUserDefinedStruct>());
            else if (type == Consts.UserDefinedStructEditorData)
                reader.Read(item.Get<UUserDefinedStructEditorData>());
            //else
            //    throw new InvalidOperationException($"Type not supported: {type}");
        }
        public static void WriteAssetObject(this BinaryWriter writer, string type, AssetObject item)
        {
            if (type == Consts.MetaData)
                writer.Write((UMetadata)item.Obj);
            else if (type == Consts.UserDefinedStruct)
                writer.Write((UUserDefinedStruct)item.Obj);
            else if (type == Consts.UserDefinedStructEditorData)
                writer.Write((UUserDefinedStructEditorData)item.Obj);
            //else
            //    throw new InvalidOperationException($"Type not supported: {type}");
        }
        #endregion

        #region Object
        public static void WriteObject(this BinaryWriter writer, object obj)
        {
            foreach (var item in obj.GetType().GetFields())
            {
                var type = Nullable.GetUnderlyingType(item.FieldType) ?? item.FieldType;
                bool isList = type.IsGenericType && type.GetGenericTypeDefinition() == typeof(List<>);
                bool isObject = false;
                if (isList)
                {
                    List<object> list = ((IEnumerable)item.GetValue(obj)).Cast<object>().ToList();
                    writer.Write(list.Count);
                    foreach (object arrayItem in list)
                    {
                        writer.WriteObject(arrayItem);
                    }
                    continue;
                }
                else if (type == typeof(char))
                    writer.Write((char)item.GetValue(obj));
                else if (type == typeof(byte))
                    writer.Write((byte)item.GetValue(obj));
                else if (type == typeof(Int16))
                    writer.Write((Int16)item.GetValue(obj));
                else if (type == typeof(UInt16))
                    writer.Write((UInt16)item.GetValue(obj));
                else if (type == typeof(Int32))
                    writer.Write((Int32)item.GetValue(obj));
                else if (type == typeof(UInt32))
                    writer.Write((UInt32)item.GetValue(obj));
                else if (type == typeof(Int64))
                    writer.Write((Int64)item.GetValue(obj));
                else if (type == typeof(UInt64))
                    writer.Write((UInt64)item.GetValue(obj));
                else if (type == typeof(FBool))
                    writer.Write((FBool)item.GetValue(obj));
                else if (type == typeof(FGuid))
                    writer.Write((FGuid)item.GetValue(obj));
                else if (type == typeof(FName))
                    writer.Write((FName)item.GetValue(obj));
                else if (type == typeof(FNameEntryId))
                    writer.Write((FNameEntryId)item.GetValue(obj));
                else if (type == typeof(FString))
                    writer.Write((FString)item.GetValue(obj));
                else if (type == typeof(TBitArray))
                    writer.Write((TBitArray)item.GetValue(obj));
                else
                {
                    isObject = true;
                }
                if (isObject)
                    writer.WriteObject(item.GetValue(obj));
            }
        }

        public static T ReadObject<T>(this BinaryReader reader, T obj) where T : new()
        {
            obj ??= new();
            foreach (var item in obj.GetType().GetFields())
            {
                Type type = Nullable.GetUnderlyingType(item.FieldType) ?? item.FieldType;
                bool isList = type.IsGenericType && type.GetGenericTypeDefinition() == typeof(List<>);
                bool isObject = false;
                if (isList)
                {
                    IList list = (IList)Activator.CreateInstance(type);
                    Type itemType = type.GenericTypeArguments[0];
                    Enumerable.Range(0, reader.ReadInt32()).ToList().ForEach(x => list.Add(Activator.CreateInstance(itemType)));
                    foreach (object arrayItem in list)
                    {
                        reader.ReadObject(arrayItem);
                    }
                    item.SetValue(obj, list);
                    continue;
                }
                else if (type == typeof(char))
                    item.SetValue(obj, reader.ReadChar());
                else if (type == typeof(byte))
                    item.SetValue(obj, reader.ReadByte());
                else if (type == typeof(Int16))
                    item.SetValue(obj, reader.ReadInt16());
                else if (type == typeof(UInt16))
                    item.SetValue(obj, reader.ReadUInt16());
                else if (type == typeof(Int32))
                    item.SetValue(obj, reader.ReadInt32());
                else if (type == typeof(UInt32))
                    item.SetValue(obj, reader.ReadUInt32());
                else if (type == typeof(Int64))
                    item.SetValue(obj, reader.ReadInt64());
                else if (type == typeof(UInt64))
                    item.SetValue(obj, reader.ReadUInt64());
                else if (type == typeof(FBool))
                    item.SetValue(obj, reader.ReadFBool());
                else if (type == typeof(FGuid))
                    item.SetValue(obj, reader.ReadFGuid());
                else if (type == typeof(FName))
                    item.SetValue(obj, reader.ReadFName());
                else if (type == typeof(FString))
                    item.SetValue(obj, reader.ReadFString());
                else
                {
                    isObject = true;
                }
                if (isObject)
                {
                    reader.ReadObject(item.GetValue(obj));
                }
            }
            return obj;
        }
        #endregion
    }
}
