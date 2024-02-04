using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    [Location("void operator<<(FStructuredArchive::FSlot Slot, FPropertyTag& Tag)")]
    public class FPropertyTag
    {
        [Location("Slot << SA_ATTRIBUTE(TEXT(\"Name\"), Tag.Name);")]
        public FName Name;

        [Location("Slot << SA_ATTRIBUTE(TEXT(\"Type\"), Tag.Type);")]
        public FName Type;

        [Location("Slot << SA_ATTRIBUTE(TEXT(\"Size\"), Tag.Size);")]
        public Int32 Size;

        public Int32 ArrayIndex;
        public byte HasPropertyGuid;

        public FName StructName;
        public FGuid StructGuid;
        public byte BoolVal;
        public FName EnumName;
        public FName InnerType;
        public FName ValueType;

        public PropertyValue Value = new();

        public List<FPropertyTag> Tags = [];
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
                    tag.Value.UpdateFrom(tag);
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
                list.Add(reader.Read(tag));
                if (tag.Name.IsFilled)
                {
                    long endOffset = reader.BaseStream.Position + tag.Size;
                    tag.Value.UpdateFrom(tag);
                    reader.Read(tag.Value);
                    if (reader.BaseStream.Position != endOffset)
                    {
                        Console.WriteLine($"Read Failed. Expected Offset {endOffset} but was {reader.BaseStream.Position}");
                        throw new InvalidOperationException();
                    }
                }
            }
            while (tag.Name.IsFilled);
        }

        public static FPropertyTag Read(this BinaryReader reader, FPropertyTag tag)
        {
            tag.Name = reader.Read(tag.Name);
            if (tag.Name.IsFilled)
            {
                tag.Type = reader.Read(tag.Type);
                reader.Read(ref tag.Size);
                reader.Read(ref tag.ArrayIndex);
                reader.ReadExtra(tag);
                reader.Read(ref tag.HasPropertyGuid);
            }
            return tag;
        }

        public static List<FPropertyTag> ReadPropertyTags(this BinaryReader reader)
        {
            List<FPropertyTag> list = new();
            FPropertyTag tag;
            // Load all stored properties, potentially skipping unknown ones.
            do
            {
                tag = new FPropertyTag();
                list.Add(reader.Read(tag));
                if (tag.Name.IsFilled)
                {
                    tag.Value.UpdateFrom(tag);
                    reader.Read(tag.Value);
                }
            }
            while (tag.Name.IsFilled);
            return list;
        }

        public static FPropertyTag ReadExtra(this BinaryReader reader, FPropertyTag tag)
        {
            if (tag.Type.Number == 0)
            {
                if (tag.Type.Value == Consts.StructProperty)
                {
                    tag.StructName = reader.Read(tag.StructName);
                    tag.StructGuid = reader.Read(tag.StructGuid);
                }
                else if (tag.Type.Value == Consts.BoolProperty)
                {
                    reader.Read(ref tag.BoolVal);
                }
                else if (tag.Type.Value == Consts.ByteProperty)
                {
                    tag.EnumName = reader.Read(tag.EnumName);
                }
                else if (tag.Type.Value == Consts.EnumProperty)
                {
                    tag.EnumName = reader.Read(tag.EnumName);
                }
                else if (tag.Type.Value == Consts.ArrayProperty)
                {
                    tag.InnerType = reader.Read(tag.InnerType);
                }
                else if (tag.Type.Value == Consts.OptionalProperty)
                {
                    tag.InnerType = reader.Read(tag.InnerType);
                }
                else if (tag.Type.Value == Consts.SetProperty)
                {
                    tag.InnerType = reader.Read(tag.InnerType);
                }
                else if (tag.Type.Value == Consts.MapProperty)
                {
                    tag.InnerType = reader.Read(tag.InnerType);
                    tag.ValueType = reader.Read(tag.ValueType);
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
