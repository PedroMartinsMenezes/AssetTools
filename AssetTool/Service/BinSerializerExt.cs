using System.Collections;
using System.Reflection;

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

        #region Transfer
        public static T MoveValue<T>(this Transfer transfer, ref T obj, FieldInfo info) where T : class, new()
        {
            if (transfer.IsReading)
                return transfer.reader.ReadValue(ref obj, info);
            else
                return transfer.writer.WriteValue(ref obj, info);
        }
        #endregion

        #region Write
        public static T WriteValue<T>(this BinaryWriter writer, ref T obj, FieldInfo info) where T : new()
        {
            obj ??= new T();
            writer.WriteValue(obj, info);
            return obj;
        }
        public static object WriteValue(this BinaryWriter writer, object obj, FieldInfo info)
        {
            var transfer = GlobalObjects.Transfer;
            Type type = obj.GetType();

            if (type.IsPrimitive)
            {
                if (type == typeof(sbyte))
                    transfer.Move((sbyte)(obj));
                else if (type == typeof(byte))
                    transfer.Move((byte)(obj));
                else if (type == typeof(Int16))
                    transfer.Move((Int16)(obj));
                else if (type == typeof(UInt16))
                    transfer.Move((UInt16)(obj));
                else if (type == typeof(Int32))
                    transfer.Move((Int32)(obj));
                else if (type == typeof(UInt32))
                    transfer.Move((UInt32)(obj));
                else if (type == typeof(Int64))
                    transfer.Move((Int64)(obj));
                else if (type == typeof(UInt64))
                    transfer.Move((UInt64)(obj));
            }
            else if (IsList(type))
                WriteList(writer, obj, info);
            else if (type.IsArray)
                WriteArray(writer, obj, info);
            else if (IsMap(type))
                WriteMap(writer, obj, type);
            else if (type == typeof(FBool))
                transfer.Move((FBool)(obj));
            else if (type == typeof(FGuid))
                transfer.Move((FGuid)(obj));
            else if (type == typeof(FName))
                writer.Write((FName)(obj));
            else if (type == typeof(FNameEntryId))
                ((FNameEntryId)obj).Move(transfer);
            else if (type == typeof(FString))
                writer.Write((FString)(obj));
            else
                WriteFields(writer, obj);
            return obj;
        }

        public static void WriteFields(this BinaryWriter writer, object obj)
        {
            foreach (var item in obj.GetType().GetFields(BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance))
            {
                if (AppConfig.EnableVerboseLog)
                    Log.Info($"[{writer.BaseStream.Position}] {item.Name}: {item.GetValue(obj)}");

                if (!CheckMember(item, obj))
                    continue;

                object value = item.GetValue(obj) ?? Activator.CreateInstance(item.FieldType);

                writer.WriteValue(value, item);
            }
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
                        writer.WriteValue(keyPart, null);
                    }
                    object value = values[i];
                    writer.WriteValue(value, null);
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
            {
                writer.WriteValue(item, info);
            }
        }

        private static bool IsSized(FieldInfo info)
        {
            return info.HasAttribute<SizedAttribute>();
        }
        #endregion

        #region Read
        public static T ReadValue<T>(this BinaryReader reader, ref T obj, FieldInfo info) where T : class, new()
        {
            obj ??= new();
            return reader.ReadValue(obj, info);
        }
        public static T ReadValue<T>(this BinaryReader reader, T obj, FieldInfo info) where T : class, new()
        {
            var transfer = GlobalObjects.Transfer;
            obj ??= new();
            Type type = obj.GetType();
            if (type.IsPrimitive)
            {
                if (type == typeof(sbyte))
                    obj = transfer.Move((sbyte)default) as T;
                else if (type == typeof(byte))
                    obj = transfer.Move((byte)default) as T;
                else if (type == typeof(Int16))
                    obj = transfer.Move((Int16)default) as T;
                else if (type == typeof(UInt16))
                    obj = transfer.Move((UInt16)default) as T;
                else if (type == typeof(Int32))
                    obj = transfer.Move((Int32)default) as T;
                else if (type == typeof(UInt32))
                    obj = transfer.Move((UInt32)default) as T;
                else if (type == typeof(Int64))
                    obj = transfer.Move((Int64)default) as T;
                else if (type == typeof(UInt64))
                    obj = transfer.Move((UInt64)default) as T;
            }
            else if (IsList(type))
                ReadList(reader, obj, type, info);
            else if (type.IsArray)
                obj = ReadArray(reader, obj, info);
            else if (IsMap(type))
                ReadMap(reader, obj, type);
            else if (type == typeof(FBool))
                obj = transfer.Move((FBool)null) as T;
            else if (type == typeof(FGuid))
                obj = transfer.Move((FGuid)default) as T;
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
            string name = string.Empty;
            try
            {
                foreach (var item in obj.GetType().GetFields(BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance))
                {
                    name = item.Name;
                    if (!CheckMember(item, obj))
                        continue;
                    object member = item.GetValue(obj) ?? Activator.CreateInstance(item.FieldType);
                    item.SetValue(obj, reader.ReadValue(member, item));

                    if (AppConfig.EnableVerboseLog)
                        Log.Info($"[{reader.BaseStream.Position}] {item.Name}: {item.GetValue(obj)}");
                }
                return obj;
            }
            catch
            {
                Log.Info($"Failed to read {name} at {reader.BaseStream.Position}");
                throw;
            }
        }

        private static bool CheckMember(FieldInfo item, object obj)
        {
            if (item.GetCustomAttribute<CheckAttribute>() is CheckAttribute attrib)
            {
                string checkMethod = attrib.Description;
                if (checkMethod == "False")
                    return false;
                string value = obj.GetType().GetMethod(checkMethod).Invoke(obj, null).ToString();
                return bool.TryParse(value, out bool canRead) && canRead;
            }
            return true;
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
            var map = obj as IDictionary;
            int count = reader.ReadInt32();
            for (int j = 0; j < count; j++)
            {
                List<string> keys = new();
                for (int i = 0; i < type.GenericTypeArguments.Length - 1; i++)
                {
                    object keyPart = Activator.CreateInstance(type.GenericTypeArguments[i]);
                    keyPart = reader.ReadValue(keyPart, null);
                    keys.Add(keyPart.ToString());
                }
                object value = Activator.CreateInstance(type.GenericTypeArguments[type.GenericTypeArguments.Length - 1]);
                value = reader.ReadValue(value, null);

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

        private static void ReadList<T>(BinaryReader reader, T obj, Type type, FieldInfo info) where T : class, new()
        {
            bool isSized = info?.GetCustomAttribute(typeof(SizedAttribute)) is { };
            var items = obj as IList;
            Type itemType = type.GenericTypeArguments[0];
            int count = isSized ? reader.ReadInt32() : 0;
            for (int i = 0; i < count; i++)
            {
                var arrayItem = Activator.CreateInstance(itemType);
                items.Add(reader.ReadValue(arrayItem, info));
            }
        }

        public static List<T> ReadList<T>(this BinaryReader reader, long offset = -1, int count = -1) where T : class, new()
        {
            if (offset > 0 && offset != reader.BaseStream.Position)
                reader.BaseStream.Position = offset;
            if (count == -1)
                count = reader.ReadInt32();
            return Enumerable.Range(0, count).Select(x => reader.ReadValue(new T(), null)).ToList();
        }

        public static void ReadList<T>(this BinaryReader reader, ref List<T> list) where T : class, new()
        {
            list ??= new();
            int count = reader.ReadInt32();
            for (int i = 0; i < count; i++)
            {
                list.Add(reader.ReadValue(new T(), null));
            }
        }

        public static void WriteList<T>(this BinaryWriter writer, List<T> list) where T : class, new()
        {
            int count = list.Count;
            for (int i = 0; i < count; i++)
            {
                writer.WriteValue(list[i], null);
            }
        }

        #endregion        
    }
}
