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
            else if (type == Consts.ArrowComponent)
                reader.Read(item.Get<UArrowComponent>());
        }
        public static void WriteAssetObject(this BinaryWriter writer, string type, AssetObject item)
        {
            if (type == Consts.MetaData)
                writer.Write((UMetadata)item.Obj);
            else if (type == Consts.UserDefinedStruct)
                writer.Write((UUserDefinedStruct)item.Obj);
            else if (type == Consts.UserDefinedStructEditorData)
                writer.Write((UUserDefinedStructEditorData)item.Obj);
            else if (type == Consts.ArrowComponent)
                writer.Write((UArrowComponent)item.Obj);
        }
        #endregion

        #region Write
        public static void WriteValue(this BinaryWriter writer, object obj, FieldInfo info = null)
        {
            Type type = obj.GetType();
            if (IsList(type))
                WriteList(writer, obj, info);
            else if (type.IsArray)
                WriteArray(writer, obj, info);
            else if (IsMap(type))
                WriteMap(writer, obj, type);
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
                WriteFields(writer, obj);
        }

        public static void WriteFields(this BinaryWriter writer, object obj)
        {
            foreach (var item in obj.GetType().GetFields(BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance))
                writer.WriteValue(item.GetValue(obj), item);
        }

        private static void WriteMap(BinaryWriter writer, object obj, Type type)
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

        private static void WriteArray(BinaryWriter writer, object obj, FieldInfo info = null)
        {
            Array items = (Array)obj;
            bool isSized = info?.GetCustomAttribute(typeof(SizedAttribute)) is { };
            if (isSized)
                writer.Write(items.Length);
            if (obj is byte[] array1)
                writer.Write(array1);
            else if (obj is UInt16[] array2)
                array2.ToList().ForEach(writer.Write);
        }

        private static void WriteList(BinaryWriter writer, object obj, FieldInfo info = null)
        {
            bool isSize = IsSized(info);
            List<object> items = ((IEnumerable)obj).Cast<object>().ToList();
            if (isSize)
                writer.Write(items.Count);
            foreach (object item in items)
                writer.WriteValue(item);
        }

        private static bool IsSized(FieldInfo info)
        {
            return info.HasAttribute<SizedAttribute>();
        }
        #endregion

        #region Read
        public static T ReadValue<T>(this BinaryReader reader, T obj, FieldInfo info = null) where T : class, new()
        {
            obj ??= new();
            Type type = obj.GetType();
            if (IsList(type))
                ReadList(reader, obj, type, info);
            else if (type.IsArray)
                obj = ReadArray(reader, obj, info);
            else if (IsMap(type))
                ReadMap(reader, obj, type);
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
                ReadFields(reader, obj);
            return obj;
        }

        public static T ReadFields<T>(this BinaryReader reader, T obj) where T : class, new()
        {
            obj ??= new();
            foreach (var item in obj.GetType().GetFields(BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance))
                item.SetValue(obj, reader.ReadValue(item.GetValue(obj) ?? Activator.CreateInstance(item.FieldType), item));
            return obj;
        }

        private static bool IsList(Type type)
        {
            return type.IsGenericType && type.GetGenericTypeDefinition() == typeof(List<>);
        }

        private static bool IsMap(Type type)
        {
            bool isMap1 = type.IsGenericType && type.GetGenericTypeDefinition() == typeof(TMap1<,>);
            bool isMap2 = type.IsGenericType && type.GetGenericTypeDefinition() == typeof(TMap2<,,>);
            return isMap1 || isMap2;
        }

        private static void ReadMap<T>(BinaryReader reader, T obj, Type type) where T : class, new()
        {
            int count = reader.ReadInt32();
            if (count > 0)
            {
                List<string> keys = new();
                for (int i = 0; i < type.GenericTypeArguments.Length - 1; i++)
                {
                    object keyPart = Activator.CreateInstance(type.GenericTypeArguments[i]);
                    keyPart = reader.ReadValue(keyPart);
                    keys.Add(keyPart.ToString());
                }
                object value = Activator.CreateInstance(type.GenericTypeArguments[type.GenericTypeArguments.Length - 1]);
                value = reader.ReadValue(value);
                var map = obj as IDictionary;
                map.Add(string.Join(' ', keys), value);
            }
        }

        private static T ReadArray<T>(BinaryReader reader, T obj, FieldInfo info = null) where T : class, new()
        {
            bool isSized = info?.GetCustomAttribute(typeof(SizedAttribute)) is { };
            if ((obj is null || (obj as Array).Length == 0) && !isSized)
            {
                throw new InvalidOperationException("Missing 'Sized' attribute.");
            }
            int count = isSized ? reader.ReadInt32() : (obj as Array).Length;
            if (obj is byte[] array1)
            {
                array1 = array1.Length == 0 ? new byte[count] : array1;
                for (int i = 0; i < count; i++)
                    array1[i] = reader.ReadByte();
                return array1 as T;
            }
            else if (obj is UInt16[] array2)
            {
                array2 = array2.Length == 0 ? new UInt16[count] : array2;
                for (int i = 0; i < count; i++)
                    array2[i] = reader.ReadUInt16();
                return array2 as T;
            }
            return obj;
        }

        private static void ReadList<T>(BinaryReader reader, T obj, Type type, FieldInfo info = null) where T : class, new()
        {
            bool isSized = info?.GetCustomAttribute(typeof(SizedAttribute)) is { };
            var items = obj as IList;
            Type itemType = type.GenericTypeArguments[0];
            int count = isSized ? reader.ReadInt32() : 0;
            for (int i = 0; i < count; i++)
            {
                var arrayItem = Activator.CreateInstance(itemType);
                items.Add(reader.ReadValue(arrayItem));
            }
        }

        public static List<T> ReadList<T>(this BinaryReader reader, long offset = -1, int count = -1) where T : class, new()
        {
            if (offset >= 0)
                reader.BaseStream.Position = offset;
            if (count == -1)
                count = reader.ReadInt32();
            return Enumerable.Range(0, count).Select(x => reader.ReadValue(new T())).ToList();
        }
        #endregion
    }
}
