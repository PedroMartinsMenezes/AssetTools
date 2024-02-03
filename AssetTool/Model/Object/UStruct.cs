using System.ComponentModel;
using System.Text.Json.Serialization;

namespace AssetTool.Model
{
    [Description("void UStruct::Serialize(FArchive& Ar)")]
    public class UStruct : UObject
    {
        [JsonPropertyOrder(-8)] public UInt32 AccessTrackedObjectPtr;
        [JsonPropertyOrder(-8)] public List<FPackageIndex> ChildArray = new();
        [JsonPropertyOrder(-8)] public List<FField> ChildProperties = new();
        [JsonPropertyOrder(-8)] public UInt32 BytecodeBufferSize;
        [JsonPropertyOrder(-8)] public UInt32 SerializedScriptSize;
    }

    //void UStruct::Serialize(FArchive& Ar)
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

                if (name == Consts.StructProperty)
                    writer.Write((FStructProperty)item);
                else if (name == Consts.EnumProperty)
                    writer.Write((FEnumProperty)item);
                else if (name == Consts.ObjectProperty)
                    writer.Write((FObjectPropertyBase)item);
                else
                    Console.WriteLine($"Invalid type: {name}");
            }
        }

        public static UStruct Read(this BinaryReader reader, UStruct item)
        {
            reader.Read((UObject)item); //68364..68475

            reader.Read(ref item.AccessTrackedObjectPtr); //68475..68479

            reader.ReadList(item.ChildArray);//68479..68507

            ReadChildProperties(reader, item.ChildProperties); //68507..68722

            reader.Read(ref item.BytecodeBufferSize);

            reader.Read(ref item.SerializedScriptSize);
            return item;
        }

        private static void ReadChildProperties(BinaryReader reader, List<FField> list)
        {
            int count = reader.ReadInt32();
            for (int i = 0; i < count; i++)
            {
                var propertyTypeName = reader.Read(new FName());
                string name = propertyTypeName.Value;

                if (name == Consts.StructProperty)
                    list.Add(reader.Read(new FStructProperty { PropertyTypeName = propertyTypeName }));
                else if (name == Consts.EnumProperty)
                    list.Add(reader.Read(new FEnumProperty { PropertyTypeName = propertyTypeName }));
                else if (name == Consts.ObjectProperty)
                    list.Add(reader.Read(new FObjectPropertyBase { PropertyTypeName = propertyTypeName }));
                else
                    Console.WriteLine($"Invalid type:  {propertyTypeName.Value}");
            }
        }
    }
}
