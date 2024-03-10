using System.Text.Json.Serialization;

namespace AssetTool
{
    [Location("void UStruct::Serialize(FArchive& Ar)")]
    public class UStruct : UObject
    {
        [JsonPropertyOrder(-8)] public UInt32 AccessTrackedObjectPtr;
        [JsonPropertyOrder(-8)][Sized] public List<FPackageIndex> ChildArray;
        [JsonPropertyOrder(-8)][Sized] public List<FField> ChildProperties;
        [JsonPropertyOrder(-8)] public UInt32 BytecodeBufferSize;
        [JsonPropertyOrder(-8)] public UInt32 SerializedScriptSize;

        [JsonPropertyOrder(-8)] public byte[] ScriptData;
    }

    public static class UStructExt
    {
        public static void Write(this BinaryWriter writer, UStruct item)
        {
            writer.Write((UObject)item);

            writer.Write(item.AccessTrackedObjectPtr);

            writer.WriteValue(item.ChildArray, item.GetType().GetField("ChildArray"));

            if (GlobalObjects.CustomVer(FCoreObjectVersion.Guid) >= (int)FCoreObjectVersion.Enums.FProperties)
            {
                WriteChildProperties(writer, item.ChildProperties);
            }
            writer.Write(item.BytecodeBufferSize);

            writer.Write(item.SerializedScriptSize);

            if (item.ScriptData is { })
                writer.Write(item.ScriptData);
        }

        private static void WriteChildProperties(BinaryWriter writer, List<FField> list)
        {
            writer.Write(list.Count);
            foreach (var item in list)
            {
                writer.Write(new FName(item.TypeName));

                if (FStructProperty.TYPE_NAME == item.TypeName) writer.Write((FStructProperty)item);
                else if (FEnumProperty.TYPE_NAME == item.TypeName) writer.Write((FEnumProperty)item);
                else if (FObjectPropertyBase.TYPE_NAME == item.TypeName) writer.Write((FObjectPropertyBase)item);
                else if (FIntProperty.TYPE_NAME == item.TypeName) writer.Write((FIntProperty)item);
                else if (FFloatProperty.TYPE_NAME == item.TypeName) writer.Write((FFloatProperty)item);
                else if (FDoubleProperty.TYPE_NAME == item.TypeName) writer.Write((FDoubleProperty)item);
                else if (FBoolProperty.TYPE_NAME == item.TypeName) writer.Write((FBoolProperty)item);
                else if (FInterfaceProperty.TYPE_NAME == item.TypeName) writer.Write((FInterfaceProperty)item);
                else if (FStrProperty.TYPE_NAME == item.TypeName) writer.Write((FStrProperty)item);
                else
                {
                    Log.Info($"[{writer.BaseStream.Position}] Invalid type: {item.TypeName}");
                    writer.Write((FProperty)item);
                }
            }
        }

        public static UStruct Read(this BinaryReader reader, UStruct item)
        {
            reader.Read((UObject)item);

            reader.Read(ref item.AccessTrackedObjectPtr);

            reader.ReadValue(ref item.ChildArray, item.GetType().GetField("ChildArray"));

            if (GlobalObjects.CustomVer(FCoreObjectVersion.Guid) >= (int)FCoreObjectVersion.Enums.FProperties)
            {
                ReadChildProperties(reader, ref item.ChildProperties);
            }
            reader.Read(ref item.BytecodeBufferSize);

            reader.Read(ref item.SerializedScriptSize);

            LoadStructWithScript(reader, item);

            return item;
        }

        [Location("bool FStructScriptLoader::LoadStructWithScript(UStruct* DestScriptContainer, FArchive& Ar, bool bAllowDeferredSerialization)")]
        private static void LoadStructWithScript(BinaryReader reader, UStruct item)
        {
            long ScriptSerializationOffset = item.SerializedScriptSize > 0 ? reader.BaseStream.Position : 0;
            long ScriptEndOffset = ScriptSerializationOffset + item.SerializedScriptSize;
            if (ScriptEndOffset > ScriptSerializationOffset)
            {
                item.ScriptData = new byte[ScriptEndOffset - ScriptSerializationOffset];
                reader.Read(item.ScriptData);
                reader.BaseStream.Position = ScriptEndOffset;
            }
        }

        private static void ReadChildProperties(BinaryReader reader, ref List<FField> list)
        {
            list ??= new();
            int count = reader.ReadInt32();
            ///if (count > 0) Log.Info("ReadChildProperties");
            for (int i = 0; i < count; i++)
            {
                FName type = reader.ReadFName();
                if (type.ComparisonIndex.Value == 0)
                    throw new InvalidOperationException($"Invalid type at {reader.BaseStream.Position}");
                string name = type.Value;
                ///Log.Info($"  {name}");

                if (name == FStructProperty.TYPE_NAME) list.Add(reader.Read(new FStructProperty()));
                else if (name == FEnumProperty.TYPE_NAME) list.Add(reader.Read(new FEnumProperty()));
                else if (name == FObjectPropertyBase.TYPE_NAME) list.Add(reader.Read(new FObjectPropertyBase()));
                else if (name == FIntProperty.TYPE_NAME) list.Add(reader.Read(new FIntProperty()));
                else if (name == FFloatProperty.TYPE_NAME) list.Add(reader.Read(new FFloatProperty()));
                else if (name == FDoubleProperty.TYPE_NAME) list.Add(reader.Read(new FDoubleProperty()));
                else if (name == FBoolProperty.TYPE_NAME) list.Add(reader.Read(new FBoolProperty()));
                else if (name == FInterfaceProperty.TYPE_NAME) list.Add(reader.Read(new FInterfaceProperty()));
                else if (name == FStrProperty.TYPE_NAME) list.Add(reader.Read(new FStrProperty()));
                else
                {
                    Log.Info($"[{reader.BaseStream.Position}] Invalid type: {name}");
                    list.Add(reader.Read(new FProperty()));
                }
            }
        }
    }
}
