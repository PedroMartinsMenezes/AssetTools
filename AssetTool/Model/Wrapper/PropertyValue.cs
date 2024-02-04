using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    public class PropertyValue
    {
        [JsonIgnore] public string Name;
        [JsonIgnore] public string StructName;
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
        public float? Value_Float;
        public string Value_Struct;

        public List<List<FPropertyTag>> Value_Array_Structs;
        public List<PropertyValue> Value_Array;

        public List<FPropertyTag> Value_Children;
        public FPropertyTag MaybeInnerTag;

        public void UpdateFrom(FPropertyTag other)
        {
            Name = other.Name.Value;
            StructName = other.StructName?.Value;
            Type = other.Type.Value;
            InnerType = other.InnerType?.Value;
            Size = other.Size;
        }
    }

    public static class PropertyValueExt
    {
        #region void FPropertyTag::SerializeTaggedProperty(FStructuredArchive::FSlot Slot, FProperty* Property, uint8* Value, const uint8* Defaults) const
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
            else if (prop.Type == Consts.ByteProperty && prop.Size == 4)
                prop.Value_Enum32 = reader.ReadUInt32();
            else if (prop.Type == Consts.EnumProperty && prop.Size == 8)
                prop.Value_Enum64 = reader.ReadUInt64();
            else if (prop.Type == Consts.ByteProperty && prop.Size == 8)
                prop.Value_Enum64 = reader.ReadUInt64();
            else if (prop.Type == Consts.SoftObjectProperty)
                prop.Value_SoftObject = reader.ReadUInt32();
            else if (prop.Type == Consts.FloatProperty)
                prop.Value_Float = reader.ReadSingle();
            else if (prop.Type == Consts.ArrayProperty)
                ReadArrayProperty(reader, prop);
            else if (prop.Type == Consts.StructProperty)
                ReadStructProperty(reader, prop);
        }

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
            else if (prop.Type == Consts.FloatProperty)
                writer.Write(prop.Value_Float.Value);
            else if (prop.Type == Consts.ArrayProperty)
                WriteArrayProperty(writer, prop);
            else if (prop.Type == Consts.StructProperty)
                WriteStructProperty(writer, prop);
        }
        #endregion

        #region void UScriptStruct::SerializeItem(FStructuredArchive::FSlot Slot, void* Value, void const* Defaults)
        private static void ReadStructProperty(this BinaryReader reader, PropertyValue prop)
        {
            if (prop.StructName == FSoftObjectPath.StructName && GlobalObjects.SoftObjectPathList.Count == 0) prop.Value_Struct = reader.ReadValue(new FSoftObjectPath()).ToJson();
            else if (prop.StructName == FSoftObjectPath.StructName && GlobalObjects.SoftObjectPathList.Count > 0) prop.Value_Struct = reader.ReadInt32().ToString();
            else if (prop.StructName == FVector2D.StructName) prop.Value_Struct = new FVector2D(reader).ToJson();
            else if (prop.StructName == Consts.Guid) prop.Value_Struct = reader.ReadFGuid().ToJson();
            else if (prop.StructName == FPointerToUberGraphFrame.StructName) prop.Value_Struct = new FPointerToUberGraphFrame(reader).ToJson();
            else if (prop.StructName == FRotator.StructName) prop.Value_Struct = new FRotator(reader).ToJson();
            else if (prop.StructName == FLinearColor.StructName) prop.Value_Struct = new FLinearColor(reader).ToJson();
            else
            {
                prop.Value_Children = [];
                reader.Read(prop.Value_Children);
            }
        }

        private static void WriteStructProperty(BinaryWriter writer, PropertyValue prop)
        {
            if (prop.StructName == FSoftObjectPath.StructName && GlobalObjects.SoftObjectPathList.Count == 0) writer.WriteValue(prop.Value_Struct.ToObject<FSoftObjectPath>());
            else if (prop.StructName == FSoftObjectPath.StructName && GlobalObjects.SoftObjectPathList.Count > 0) writer.Write(int.Parse(prop.Value_Struct));
            else if (prop.StructName == FVector2D.StructName) writer.WriteValue(prop.Value_Struct.ToObject<FVector2D>());
            else if (prop.StructName == Consts.Guid) writer.WriteValue(prop.Value_Struct.ToObject<FGuid>());
            else if (prop.StructName == FPointerToUberGraphFrame.StructName) writer.WriteValue(prop.Value_Struct.ToObject<FPointerToUberGraphFrame>());
            else if (prop.StructName == FRotator.StructName) writer.WriteValue(prop.Value_Struct.ToObject<FRotator>());
            else if (prop.StructName == FLinearColor.StructName) writer.WriteValue(prop.Value_Struct.ToObject<FLinearColor>());
            else if (prop.Value_Children is { })
            {
                writer.Write(prop.Value_Children);
            }
        }
        #endregion

        #region void FArrayProperty::SerializeItem(FStructuredArchive::FSlot Slot, void* Value, void const* Defaults) const")]
        private static void ReadArrayProperty(BinaryReader reader, PropertyValue prop)
        {
            if (prop.InnerType == Consts.StructProperty)
            {
                prop.Value_Array_Structs = new();
                prop.Value_Array_Structs.Resize(reader.ReadInt32());
                prop.MaybeInnerTag = reader.Read(new FPropertyTag());

                /// Serialize each item until we get to the end of the array
                foreach (var item in prop.Value_Array_Structs)
                {
                    reader.Read(item);
                }
            }
            else
            {
                prop.Value_Array ??= new();
                prop.Value_Array.Resize(reader.ReadInt32());
                prop.Value_Array.ForEach(x => x.Type = prop.InnerType);
                prop.Value_Array.ForEach(x => reader.Read(x));
            }
        }

        private static void WriteArrayProperty(BinaryWriter writer, PropertyValue prop)
        {
            if (prop.InnerType == Consts.StructProperty)
            {
                writer.Write(prop.Value_Array_Structs.Count);
                writer.Write(prop.MaybeInnerTag);
                prop.Value_Array_Structs.ForEach(writer.Write);
            }
            else
            {
                writer.Write(prop.Value_Array.Count);
                prop.Value_Array.ForEach(x => x.Type = prop.InnerType);
                prop.Value_Array.ForEach(x => writer.Write(x));
            }
        }
        #endregion
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
