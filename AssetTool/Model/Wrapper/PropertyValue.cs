using AssetTool.Model.Const;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    public class PropertyValue
    {
        [JsonIgnore] public string Name;
        [JsonIgnore] public string Type;
        [JsonIgnore] public string InnerType;
        [JsonIgnore] public int Size;

        public FGuid Value_Guid;
        public FName Value_Name;
        public FString Value_String;
        public Int32? Value_Int;
        public UInt32? Value_ObjectHandle;
        public UInt32? Value_UInt32;
        public UInt32? Value_Enum32;
        public UInt64? Value_Enum64;
        public UInt32? Value_SoftObject;

        public List<List<FPropertyTag>> Value_Array_Properties;
        public List<PropertyValue> Value_Array_Values;

        public List<FPropertyTag> Value_Children;
        public FPropertyTag MaybeInnerTag;

        public void UpdateFrom(FPropertyTag other)
        {
            Name = other.Name.Value;
            Type = other.Type.Value;
            InnerType = other.InnerType?.Value;
            Size = other.Size;
        }
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
                writer.Write(prop.Value_Int.Value);
            else if (prop.Type == Consts.UInt32Property)
                writer.Write(prop.Value_UInt32.Value);
            else if (prop.Type == Consts.ObjectProperty)
                writer.Write(prop.Value_ObjectHandle.Value);
            else if (prop.Type == Consts.EnumProperty && prop.Size == 4)
                writer.Write(prop.Value_Enum32.Value);
            else if (prop.Type == Consts.EnumProperty && prop.Size == 8)
                writer.Write(prop.Value_Enum64.Value);
            else if (prop.Type == Consts.SoftObjectProperty)
                writer.Write(prop.Value_SoftObject.Value);
            else if (prop.Type == Consts.ArrayProperty)
                WriteArrayProperty(writer, prop);
        }

        private static void WriteArrayProperty(BinaryWriter writer, PropertyValue prop)
        {
            if (prop.InnerType == Consts.StructProperty)
            {
                writer.Write(prop.Value_Array_Properties.Count);
                writer.Write(prop.MaybeInnerTag);
                prop.Value_Array_Properties.ForEach(writer.Write);
            }
            else if (prop.InnerType == Consts.ObjectProperty)
            {
                writer.Write(prop.Value_Array_Values.Count);
                prop.Value_Array_Values.ForEach(x => x.Type = prop.InnerType);
                prop.Value_Array_Values.ForEach(x => writer.Write(x));
            }
            else
            {
                throw new InvalidOperationException($"Invalid Array InnerType '{prop.InnerType}'");
            }
        }

        //void FPropertyTag::SerializeTaggedProperty(FStructuredArchive::FSlot Slot, FProperty* Property, uint8* Value, const uint8* Defaults) const
        public static void Read(this BinaryReader reader, PropertyValue prop)
        {
            //check Name
            if (prop.Name is Consts.Guid or Consts.VarGuid)
                prop.Value_Guid = reader.Read(prop.Value_Guid);
            else if (prop.Name == Consts.PinValueType)
                prop.Value_Children = reader.ReadPropertyTags();
            //check Type
            else if (prop.Type == Consts.StrProperty)
                prop.Value_String = reader.Read(prop.Value_String);
            else if (prop.Type == Consts.NameProperty)
                prop.Value_Name = reader.Read(prop.Value_Name);
            else if (prop.Type == Consts.IntProperty)
                prop.Value_Int = reader.ReadInt32();
            else if (prop.Type == Consts.UInt32Property)
                prop.Value_UInt32 = reader.ReadUInt32();
            else if (prop.Type == Consts.ObjectProperty)
                prop.Value_ObjectHandle = reader.ReadUInt32();
            else if (prop.Type == Consts.EnumProperty && prop.Size == 4)
                prop.Value_Enum32 = reader.ReadUInt32();
            else if (prop.Type == Consts.EnumProperty && prop.Size == 8)
                prop.Value_Enum64 = reader.ReadUInt64();
            else if (prop.Type == Consts.SoftObjectProperty)
                prop.Value_SoftObject = reader.ReadUInt32();
            else if (prop.Type == Consts.ArrayProperty)
                ReadArrayProperty(reader, prop);
            ///else if (prop.Size > 0)
            ///    throw new ArgumentException($"Invalid param: Type({prop.Type}) Name({prop.Name}) Size({prop.Size})");
        }

        //void FArrayProperty::SerializeItem(FStructuredArchive::FSlot Slot, void* Value, void const* Defaults) const
        private static void ReadArrayProperty(BinaryReader reader, PropertyValue prop)
        {
            if (prop.InnerType == Consts.StructProperty)
            {
                prop.Value_Array_Properties = new();
                prop.Value_Array_Properties.Resize(reader.ReadInt32());
                prop.MaybeInnerTag = reader.Read(new FPropertyTag());
                prop.Value_Array_Properties.ForEach(reader.Read);
            }
            else if (prop.InnerType == Consts.ObjectProperty)
            {
                prop.Value_Array_Values ??= new();
                prop.Value_Array_Values.Resize(reader.ReadInt32());
                prop.Value_Array_Values.ForEach(x => x.Type = prop.InnerType);
                prop.Value_Array_Values.ForEach(x => reader.Read(x));
            }
            else
            {
                throw new InvalidOperationException($"Invalid Array InnerType '{prop.InnerType}'");
            }
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
                writer.WriteStringValue(prop.Value_String.Value);
            else if (prop.Type == Consts.NameProperty)
                writer.WriteStringValue(prop.Value_Name.Value);
            else if (prop.Type == Consts.IntProperty)
                writer.WriteNumberValue(prop.Value_Int.Value);
            else if (prop.Type == Consts.UInt32Property)
                writer.WriteNumberValue(prop.Value_UInt32.Value);
            else if (prop.Type == Consts.ObjectProperty)
                writer.WriteNumberValue(prop.Value_ObjectHandle.Value);
            else if (prop.Type == Consts.EnumProperty && prop.Size == 4)
                writer.WriteNumberValue(prop.Value_Enum32.Value);
            else if (prop.Type == Consts.EnumProperty && prop.Size == 8)
                writer.WriteNumberValue(prop.Value_Enum64.Value);
            else if (prop.Type == Consts.SoftObjectProperty)
                writer.WriteNumberValue(prop.Value_SoftObject.Value);
        }
    }
}
