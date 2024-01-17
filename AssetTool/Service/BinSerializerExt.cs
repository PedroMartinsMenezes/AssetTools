using AssetTool.Model;
using AssetTool.Model.Const;
using System.Collections;
using System.Reflection;

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
        }
        public static void WriteAssetObject(this BinaryWriter writer, string type, AssetObject item)
        {
            if (type == Consts.MetaData)
                writer.Write((UMetadata)item.Obj);
            else if (type == Consts.UserDefinedStruct)
                writer.Write((UUserDefinedStruct)item.Obj);
            else if (type == Consts.UserDefinedStructEditorData)
                writer.Write((UUserDefinedStructEditorData)item.Obj);
        }
        #endregion

        #region Write
        public static void WriteValue(this BinaryWriter writer, object obj, FieldInfo info = null)
        {
            Type type = obj.GetType();
            bool isSize = info.HasAttribute<SizeAttribute>();
            bool isList = type.IsGenericType && type.GetGenericTypeDefinition() == typeof(List<>);
            bool isMap2 = type.IsGenericType && type.GetGenericTypeDefinition() == typeof(TMap2<,,>);
            if (isList)
            {
                List<object> items = ((IEnumerable)obj).Cast<object>().ToList();
                if (isSize)
                    writer.Write(items.Count);
                foreach (object item in items)
                    writer.WriteValue(item);
            }
            else if (type.IsArray)
            {
                Array items = (Array)obj;
                foreach (object item in items)
                    writer.WriteValue(item);
            }
            else if (isMap2)
            {
                var map = obj as IDictionary;
                writer.Write(map.Count);
                if (map.Count > 0)
                {
                    List<string> keys = map.Keys.Cast<string>().ToList();
                    List<object> values = map.Values.Cast<object>().ToList();
                    for (int i = 0; i < keys.Count; i++)
                    {
                        string key = keys[i];
                        string[] parts = key.Split(' ');
                        for (int j = 0; j < parts.Length; j++)
                        {
                            string part = parts[j];
                            object keyPart = Activator.CreateInstance(type.GenericTypeArguments[j], part);
                            writer.WriteValue(keyPart);
                        }
                        object value = values[i];
                        writer.WriteValue(value);
                    }
                }
            }
            else if (type == typeof(char))
                writer.Write((char)(obj));
            else if (type == typeof(byte))
                writer.Write((byte)(obj));
            else if (type == typeof(Int16))
                writer.Write((Int16)(obj));
            else if (type == typeof(UInt16))
                writer.Write((UInt16)(obj));
            else if (type == typeof(Int32))
                writer.Write((Int32)(obj));
            else if (type == typeof(UInt32))
                writer.Write((UInt32)(obj));
            else if (type == typeof(Int64))
                writer.Write((Int64)(obj));
            else if (type == typeof(UInt64))
                writer.Write((UInt64)(obj));
            else if (type == typeof(FBool))
                writer.Write((FBool)(obj));
            else if (type == typeof(FGuid))
                writer.Write((FGuid)(obj));
            else if (type == typeof(FName))
                writer.Write((FName)(obj));
            else if (type == typeof(FNameEntryId))
                writer.Write((FNameEntryId)(obj));
            else if (type == typeof(FString))
                writer.Write((FString)(obj));
            else if (type == typeof(TBitArray))
                writer.Write((TBitArray)(obj));
            else
            {
                foreach (var item in obj.GetType().GetFields())
                    writer.WriteValue(item.GetValue(obj), item);
            }
        }
        #endregion

        #region Read
        public static T ReadValue<T>(this BinaryReader reader, T obj, bool isArray = false) where T : class, new()
        {
            obj ??= new();
            Type type = obj.GetType();
            bool isList = type.IsGenericType && type.GetGenericTypeDefinition() == typeof(List<>);
            bool isMap1 = type.IsGenericType && type.GetGenericTypeDefinition() == typeof(TMap1<,>);
            bool isMap2 = type.IsGenericType && type.GetGenericTypeDefinition() == typeof(TMap2<,,>);
            if (isList)
            {
                var items = obj as IList;
                Type itemType = type.GenericTypeArguments[0];
                int count = isArray ? reader.ReadInt32() : 0;
                for (int i = 0; i < count; i++)
                {
                    var arrayItem = Activator.CreateInstance(itemType);
                    items.Add(reader.ReadValue(arrayItem));
                }
            }
            else if (type.IsArray)
            {
                Array items = obj as Array;
                var list = new ArrayList();
                foreach (object item in items)
                {
                    list.Add(reader.ReadValue(item));
                }
                Array.Copy(list.ToArray(), items, items.Length);
            }
            else if (isMap1)
            {
                int count = reader.ReadInt32();
                if (count > 0)
                {
                    object key1 = Activator.CreateInstance(type.GenericTypeArguments[0]);
                    object value = Activator.CreateInstance(type.GenericTypeArguments[1]);
                    key1 = reader.ReadValue(key1);
                    value = reader.ReadValue(value);
                    var map = obj as IDictionary;
                    map.Add($"{key1}", value);
                }
            }
            else if (isMap2)
            {
                int count = reader.ReadInt32();
                if (count > 0)
                {
                    object key1 = Activator.CreateInstance(type.GenericTypeArguments[0]);
                    object key2 = Activator.CreateInstance(type.GenericTypeArguments[1]);
                    object value = Activator.CreateInstance(type.GenericTypeArguments[2]);
                    key1 = reader.ReadValue(key1);
                    key2 = reader.ReadValue(key2);
                    value = reader.ReadValue(value);
                    var map = obj as IDictionary;
                    map.Add($"{key1} {key2}", value);
                }
            }
            else if (type == typeof(char))
                obj = reader.ReadChar() as T;
            else if (type == typeof(byte))
                obj = reader.ReadByte() as T;
            else if (type == typeof(Int16))
                obj = reader.ReadInt16() as T;
            else if (type == typeof(UInt16))
                obj = reader.ReadUInt16() as T;
            else if (type == typeof(Int32))
                obj = reader.ReadInt32() as T;
            else if (type == typeof(UInt32))
                obj = reader.ReadUInt32() as T;
            else if (type == typeof(Int64))
                obj = reader.ReadInt64() as T;
            else if (type == typeof(UInt64))
                obj = reader.ReadUInt64() as T;
            else if (type == typeof(FBool))
                obj = reader.ReadFBool() as T;
            else if (type == typeof(FGuid))
                obj = reader.ReadFGuid() as T;
            else if (type == typeof(FName))
                obj = reader.ReadFName() as T;
            else if (type == typeof(FString))
                obj = reader.ReadFString() as T;
            else
            {
                foreach (var item in obj.GetType().GetFields())
                {
                    isArray = item.GetCustomAttribute(typeof(SizeAttribute)) is { };
                    object value = item.GetValue(obj);
                    value = value ?? Activator.CreateInstance(item.FieldType);
                    value = reader.ReadValue(value, isArray);
                    item.SetValue(obj, value);
                }
            }
            return obj;
        }

        public static List<T> ReadList<T>(this BinaryReader reader, long offset, int count) where T : class, new()
        {
            reader.BaseStream.Position = offset;
            return Enumerable.Range(0, count).Select(x => reader.ReadValue(new T())).ToList();
        }


        #endregion
    }
}
