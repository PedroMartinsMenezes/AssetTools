using AssetTool.Model.Const;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    public class FPropertyTag
    {
        public FName Name = new();
        public FName Type = new();
        public Int32 Size;
        public Int32 ArrayIndex;
        public byte HasPropertyGuid;

        public FName StructName = new();
        public FGuid StructGuid;
        public byte BoolVal;
        public FName EnumName = new();
        public FName InnerType = new();
        public FName ValueType = new();

        public PropertyValue Value = new();
    }

    public static class FPropertyTagExt
    {
        public static void Write(this BinaryWriter writer, List<FPropertyTag> list)
        {
            foreach (var tag in list)
            {
                writer.Write(tag);
                if (tag.Name.IsFilled)
                {
                    tag.Value.Name = tag.Name.Value;
                    tag.Value.Type = tag.Type.Value;
                    tag.Value.Size = tag.Size;
                    writer.Write(tag.Value);
                }
            }
        }

        public static void Write(this BinaryWriter writer, FPropertyTag tag)
        {
            writer.Write(tag.Name);
            if (tag.Name.IsFilled)
            {
                writer.Write(tag.Type);
                writer.Write(tag.Size);
                writer.Write(tag.ArrayIndex);
                writer.WriteExtra(tag);
                writer.Write(tag.HasPropertyGuid);
            }
        }

        public static void Read(this BinaryReader reader, List<FPropertyTag> list)
        {
            FPropertyTag tag;
            // Load all stored properties, potentially skipping unknown ones.
            do
            {
                tag = new FPropertyTag();
                ///PropertyRecord << SA_VALUE(TEXT("Tag"), Tag);
                list.Add(reader.Read(tag));
                ///Tag.SerializeTaggedProperty(ValueSlot, Property, DestAddress, DefaultsFromParent);
                if (tag.Name.IsFilled)
                {
                    tag.Value.Name = tag.Name.Value;
                    tag.Value.Type = tag.Type.Value;
                    tag.Value.Size = tag.Size;
                    reader.Read(tag.Value);
                }
            }
            while (tag.Name.IsFilled);
        }

        public static FPropertyTag Read(this BinaryReader reader, FPropertyTag tag)
        {
            reader.Read(tag.Name); ///Slot << SA_ATTRIBUTE(TEXT("Name"), Tag.Name);
            if (tag.Name.IsFilled)
            {
                reader.Read(tag.Type); ///Slot << SA_ATTRIBUTE(TEXT("Type"), Tag.Type);
                reader.Read(ref tag.Size); ///Slot << SA_ATTRIBUTE(TEXT("Size"), Tag.Size);
                reader.Read(ref tag.ArrayIndex); ///Slot << SA_ATTRIBUTE(TEXT("ArrayIndex"), Tag.ArrayIndex);
                reader.ReadExtra(tag);
                reader.Read(ref tag.HasPropertyGuid); ///Slot << SA_ATTRIBUTE(TEXT("HasPropertyGuid"), Tag.HasPropertyGuid);
            }
            return tag;
        }

        public static FPropertyTag ReadExtra(this BinaryReader reader, FPropertyTag tag)
        {
            if (tag.Type.Number == 0)
            {
                if (tag.Type.Value == Consts.StructProperty)
                {
                    ///Slot << SA_ATTRIBUTE(TEXT("StructName"), Tag.StructName);
                    reader.Read(tag.StructName);
                    ///Slot << SA_ATTRIBUTE(TEXT("StructGuid"), Tag.StructGuid);
                    reader.Read(ref tag.StructGuid);
                }
                else if (tag.Type.Value == Consts.BoolProperty)
                {
                    reader.Read(ref tag.BoolVal);
                }
                else if (tag.Type.Value == Consts.ByteProperty)
                {
                    reader.Read(tag.EnumName);
                }
                else if (tag.Type.Value == Consts.EnumProperty)
                {
                    reader.Read(tag.EnumName);
                }
                else if (tag.Type.Value == Consts.ArrayProperty)
                {
                    reader.Read(tag.InnerType);
                }
                else if (tag.Type.Value == Consts.OptionalProperty)
                {
                    reader.Read(tag.InnerType);
                }
                else if (tag.Type.Value == Consts.SetProperty)
                {
                    reader.Read(tag.InnerType);
                }
                else if (tag.Type.Value == Consts.MapProperty)
                {
                    reader.Read(tag.InnerType);
                    reader.Read(tag.ValueType);
                }
            }
            return tag;
        }

        public static void WriteExtra(this BinaryWriter writer, FPropertyTag item)
        {
            if (item.Type.Number == 0)
            {
                if (item.Type.Value == Consts.StructProperty)
                {
                    writer.Write(item.StructName);
                    writer.Write(item.StructGuid);
                }
                else if (item.Type.Value == Consts.BoolProperty)
                {
                    writer.Write(item.BoolVal);
                }
                else if (item.Type.Value == Consts.ByteProperty)
                {
                    writer.Write(item.EnumName);
                }
                else if (item.Type.Value == Consts.EnumProperty)
                {
                    writer.Write(item.EnumName);
                }
                else if (item.Type.Value == Consts.ArrayProperty)
                {
                    writer.Write(item.InnerType);
                }
                else if (item.Type.Value == Consts.OptionalProperty)
                {
                    writer.Write(item.InnerType);
                }
                else if (item.Type.Value == Consts.SetProperty)
                {
                    writer.Write(item.InnerType);
                }
                else if (item.Type.Value == Consts.MapProperty)
                {
                    writer.Write(item.InnerType);
                    writer.Write(item.ValueType);
                }
            }
        }
    }

    public class FPropertyTagJsonConverter : JsonConverter<FPropertyTag>
    {
        public override FPropertyTag Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return new FPropertyTag();
        }
        public override void Write(Utf8JsonWriter writer, FPropertyTag value, JsonSerializerOptions options)
        {
            if (value.Name.Value == Consts.None)
            {
                writer.WriteString("Name", "None");
            }
            else if (value.Name.Value is Consts.Guid or Consts.VarGuid)
            {
                writer.WriteStartObject();
                writer.WriteString("Type", "Guid");
                writer.WriteString("Value", value.Value.ToJson());
                writer.WriteEndObject();
            }
        }
    }
}
