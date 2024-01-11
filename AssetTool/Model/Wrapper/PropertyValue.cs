using AssetTool.Model.Const;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    public class PropertyValue
    {
        [JsonIgnore] public string Name;
        [JsonIgnore] public string Type;
        [JsonIgnore] public int Size;

        public FGuid Value_Guid;
        public FName Value_Name = new();
        public FString Value_String = new();
        public Int32 Value_Int;
        public UInt32 Value_ObjectHandle;
        public UInt32 Value_UInt32;
        public UInt32 Value_Enum32;
        public UInt64 Value_Enum64;
        public UInt32 Value_SoftObject;
        public List<List<FPropertyTag>> Value_ArrayProperty = new();
        public List<FPropertyTag> Value_Children = new();
        public FPropertyTag MaybeInnerTag;
    }

    public static class PropertyValueExt
    {
        public static void Write(this BinaryWriter writer, PropertyValue prop)
        {
            //check Name
            if (prop.Name is Consts.Guid or Consts.VarGuid)
                writer.Write(prop.Value_Guid);
            else if (prop.Name == Consts.PinValueType)
                writer.Write(prop.Value_Children);
            //check Type
            else if (prop.Type == Consts.StrProperty)
                writer.Write(prop.Value_String);
            else if (prop.Type == Consts.NameProperty)
                writer.Write(prop.Value_Name);
            else if (prop.Type == Consts.IntProperty)
                writer.Write(prop.Value_Int);
            else if (prop.Type == Consts.UInt32Property)
                writer.Write(prop.Value_UInt32);
            else if (prop.Type == Consts.ObjectProperty)
                writer.Write(prop.Value_ObjectHandle);
            else if (prop.Type == Consts.EnumProperty && prop.Size == 4)
                writer.Write(prop.Value_Enum32);
            else if (prop.Type == Consts.EnumProperty && prop.Size == 8)
                writer.Write(prop.Value_Enum64);
            else if (prop.Type == Consts.SoftObjectProperty)
                writer.Write(prop.Value_SoftObject);
            else if (prop.Type == Consts.ArrayProperty)
                WriteArrayProperty(writer, prop);
        }

        private static void WriteArrayProperty(BinaryWriter writer, PropertyValue prop)
        {
            writer.Write(prop.Value_ArrayProperty.Count);
            writer.Write(prop.MaybeInnerTag);
            prop.Value_ArrayProperty.ForEach(writer.Write);
        }

        public static void Read(this BinaryReader reader, PropertyValue prop)
        {
            //check Name
            if (prop.Name is Consts.Guid or Consts.VarGuid)
                reader.Read(ref prop.Value_Guid);
            else if (prop.Name == Consts.PinValueType)
                reader.Read(prop.Value_Children);
            //check Type
            else if (prop.Type == Consts.StrProperty)
                reader.Read(prop.Value_String);
            else if (prop.Type == Consts.NameProperty)
                reader.Read(prop.Value_Name);
            else if (prop.Type == Consts.IntProperty)
                reader.Read(ref prop.Value_Int);
            else if (prop.Type == Consts.UInt32Property)
                reader.Read(ref prop.Value_UInt32);
            else if (prop.Type == Consts.ObjectProperty)
                reader.Read(ref prop.Value_ObjectHandle);
            else if (prop.Type == Consts.EnumProperty && prop.Size == 4)
                reader.Read(ref prop.Value_Enum32);
            else if (prop.Type == Consts.EnumProperty && prop.Size == 8)
                reader.Read(ref prop.Value_Enum64);
            else if (prop.Type == Consts.SoftObjectProperty)
                reader.Read(ref prop.Value_SoftObject);
            else if (prop.Type == Consts.ArrayProperty)
                ReadArrayProperty(reader, prop);
            else if (prop.Size > 0)
                throw new ArgumentException($"Invalid param: Type({prop.Type}) Name({prop.Name}) Size({prop.Size})");
        }

        private static void ReadArrayProperty(BinaryReader reader, PropertyValue prop)
        {
            prop.Value_ArrayProperty.Resize(reader.ReadInt32());
            prop.MaybeInnerTag = reader.Read(new FPropertyTag());
            prop.Value_ArrayProperty.ForEach(reader.Read);
        }
    }

    public class PropertyValueJsonConverter : JsonConverter<PropertyValue>
    {
        public override PropertyValue Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.GetString().ToObject<PropertyValue>();
        }
        public override void Write(Utf8JsonWriter writer, PropertyValue prop, JsonSerializerOptions options)
        {
            //check Name
            if (prop.Name is Consts.Guid or Consts.VarGuid)
                writer.WriteStringValue(prop.Value_Guid.Value);
            else if (prop.Name == Consts.PinValueType)
                writer.WriteRawValue(prop.Value_Children.ToJson());
            //check Type
            else if (prop.Type == Consts.StrProperty)
                writer.WriteString("Value", prop.Value_String.Value);
            else if (prop.Type == Consts.NameProperty)
                writer.WriteString("Value", prop.Value_Name.Value);
            else if (prop.Type == Consts.IntProperty)
                writer.WriteNumber("Value", prop.Value_Int);
            else if (prop.Type == Consts.UInt32Property)
                writer.WriteNumber("Value", prop.Value_UInt32);
            else if (prop.Type == Consts.ObjectProperty)
                writer.WriteNumber("Value", prop.Value_ObjectHandle);
            else if (prop.Type == Consts.EnumProperty && prop.Size == 4)
                writer.WriteNumber("Value", prop.Value_Enum32);
            else if (prop.Type == Consts.EnumProperty && prop.Size == 8)
                writer.WriteNumber("Value", prop.Value_Enum64);
            else if (prop.Type == Consts.SoftObjectProperty)
                writer.WriteNumber("Value", prop.Value_SoftObject);
            else if (prop.Type == Consts.ArrayProperty)
            {
                writer.WriteString("Value", "MaybeInnerTag");
                //writer.WriteRawValue(prop.MaybeInnerTag.ToJson());
                //writer.WriteRawValue(prop.Value_ArrayProperty.ToJson());
            }
            else
            {
                writer.WriteString("Value", "Vazio");
            }
        }
    }
}
