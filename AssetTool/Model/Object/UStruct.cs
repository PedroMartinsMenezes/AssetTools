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

            WriteChildProperties(writer, item.ChildProperties);

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

                if (new FStructProperty().TypeName == item.TypeName) writer.Write((FStructProperty)item);
                else if (new FEnumProperty().TypeName == item.TypeName) writer.Write((FEnumProperty)item);
                else if (new FObjectPropertyBase().TypeName == item.TypeName) writer.Write((FObjectPropertyBase)item);
                else if (new FIntProperty().TypeName == item.TypeName) writer.Write((FIntProperty)item);
                else if (new FFloatProperty().TypeName == item.TypeName) writer.Write((FFloatProperty)item);
                else if (new FDoubleProperty().TypeName == item.TypeName) writer.Write((FDoubleProperty)item);
                else if (new FBoolProperty().TypeName == item.TypeName) writer.Write((FBoolProperty)item);
                else if (new FInterfaceProperty().TypeName == item.TypeName) writer.Write((FInterfaceProperty)item);
                else if (new FStrProperty().TypeName == item.TypeName) writer.Write((FStrProperty)item);
                else
                {
                    Log.Info($"[{writer.BaseStream.Position}] Invalid type: {item.TypeName}");
                    writer.Write((FProperty)item);
                }
            }
        }

        public static UStruct Read(this BinaryReader reader, UStruct item)
        {
            reader.Read((UObject)item); //?..74414

            reader.Read(ref item.AccessTrackedObjectPtr);

            reader.ReadValue(ref item.ChildArray, item.GetType().GetField("ChildArray"));

            ReadChildProperties(reader, ref item.ChildProperties);

            //78028..78036
            reader.Read(ref item.BytecodeBufferSize); //78028..

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

                if (new FStructProperty() is var structProperty && structProperty.TypeName == name) list.Add(reader.Read(structProperty));
                else if (new FEnumProperty() is var enumProperty && enumProperty.TypeName == name) list.Add(reader.Read(enumProperty));
                else if (new FObjectPropertyBase() is var objectProperty && objectProperty.TypeName == name) list.Add(reader.Read(objectProperty));
                else if (new FIntProperty() is var intProperty && intProperty.TypeName == name) list.Add(reader.Read(intProperty));
                else if (new FFloatProperty() is var floatProperty && floatProperty.TypeName == name) list.Add(reader.Read(floatProperty));
                else if (new FDoubleProperty() is var doubleProperty && doubleProperty.TypeName == name) list.Add(reader.Read(doubleProperty));
                else if (new FBoolProperty() is var boolProperty && boolProperty.TypeName == name) list.Add(reader.Read(boolProperty));
                else if (new FInterfaceProperty() is var interfaceProperty && interfaceProperty.TypeName == name) list.Add(reader.Read(interfaceProperty));
                else if (new FStrProperty() is var strProperty && strProperty.TypeName == name) list.Add(reader.Read(strProperty));
                else
                {
                    Log.Info($"[{reader.BaseStream.Position}] Invalid type: {name}");
                    list.Add(reader.Read(new FProperty()));
                }
            }
        }
    }
}
