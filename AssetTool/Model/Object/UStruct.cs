using System.Text.Json.Serialization;

namespace AssetTool
{
    [Location("void UStruct::Serialize(FArchive& Ar)")]
    public class UStruct : UObject
    {
        [JsonPropertyOrder(-8)] public UInt32 AccessTrackedObjectPtr;
        [JsonPropertyOrder(-8)] public List<FPackageIndex> ChildArray = new();
        [JsonPropertyOrder(-8)] public List<FField> ChildProperties = new();
        [JsonPropertyOrder(-8)] public UInt32 BytecodeBufferSize;
        [JsonPropertyOrder(-8)] public UInt32 SerializedScriptSize;
    }

    public static class UStructExt
    {
        public static void Write(this BinaryWriter writer, UStruct item)
        {
            writer.Write((UObject)item);

            writer.Write(item.AccessTrackedObjectPtr);

            writer.WriteList(item.ChildArray);

            WriteChildProperties(writer, item.ChildProperties);

            writer.Write(item.BytecodeBufferSize);

            writer.Write(item.SerializedScriptSize);
        }

        private static void WriteChildProperties(BinaryWriter writer, List<FField> list)
        {
            foreach (var item in list)
            {
                string name = item.PropertyTypeName.Value;

                if (name == Consts.StructProperty) writer.Write((FStructProperty)item);
                else if (name == Consts.EnumProperty) writer.Write((FEnumProperty)item);
                else if (name == Consts.ObjectProperty) writer.Write((FObjectPropertyBase)item);
                else Console.WriteLine($"Invalid type: {name}");
            }
        }

        public static UStruct Read(this BinaryReader reader, UStruct item)
        {
            reader.Read((UObject)item);

            reader.Read(ref item.AccessTrackedObjectPtr);

            reader.ReadList(item.ChildArray);

            ReadChildProperties(reader, item.ChildProperties); //74422..78028

            //78028..78036
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
                reader.BaseStream.Position = ScriptEndOffset;
        }

        private static void ReadChildProperties(BinaryReader reader, List<FField> list)
        {
            int count = reader.ReadInt32();
            if (count > 0) Console.WriteLine("ReadChildProperties");
            for (int i = 0; i < count; i++)
            {
                FName propertyTypeName = null;
                reader.Read(ref propertyTypeName);
                string name = propertyTypeName.Value;
                Console.WriteLine($"  {name}");

                if (name == Consts.StructProperty) list.Add(reader.Read(new FStructProperty { PropertyTypeName = propertyTypeName }));
                else if (name == Consts.EnumProperty) list.Add(reader.Read(new FEnumProperty { PropertyTypeName = propertyTypeName }));
                else if (name == Consts.ObjectProperty) list.Add(reader.Read(new FObjectPropertyBase { PropertyTypeName = propertyTypeName }));
                else if (name == Consts.IntProperty) list.Add(reader.Read(new FNumericProperty()));
                else if (name == Consts.FloatProperty) list.Add(reader.Read(new FNumericProperty()));
                else if (name == Consts.DoubleProperty) list.Add(reader.Read(new FNumericProperty()));
                else if (name == Consts.BoolProperty) list.Add(reader.Read(new FBoolProperty()));
                else if (name == Consts.InterfaceProperty) list.Add(reader.Read(new FInterfaceProperty()));
                else
                {
                    Console.WriteLine($"[{reader.BaseStream.Position}] Invalid type:  {propertyTypeName.Value}");
                }
            }
        }
    }
}
