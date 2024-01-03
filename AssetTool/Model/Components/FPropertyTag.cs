namespace AssetTool.Model.Components
{
    public class FPropertyTag
    {
        public FName Type = new();
        public byte BoolVal;
        public FName Name = new();
        public FName StructName = new();
        public FName EnumName = new();
        public FName InnerType = new();
        public FName ValueType = new();
        public Int32 Size;
        public Int32 ArrayIndex;
        public Int64 SizeOffset;
        public FGuid StructGuid;
        public byte HasPropertyGuid;
        public FGuid PropertyGuid;
    }

    public static class FPropertyTagExt
    {
        public static void Write(this BinaryWriter writer, FPropertyTag item)
        {
            writer.Write(item.Name);
            if (item.Name.Value != "None")
            {
                writer.Write(item.Type);
                writer.Write(item.Size);
                writer.Write(item.ArrayIndex);
                //TODO implement
            }
        }

        public static FPropertyTag Read(this BinaryReader reader, FPropertyTag item)
        {
            reader.Read(item.Name);
            if (item.Name.Value != "None")
            {
                reader.Read(item.Type);
                reader.Read(ref item.Size);
                reader.Read(ref item.ArrayIndex);
                if (item.Name.Number == 0)
                {
                    var tagType = item.Type.Value;
                    if (tagType == "StructProperty")
                    {
                        reader.Read(item.StructName);
                        reader.Read(ref item.StructGuid);
                    }
                    else if (tagType == "BoolProperty")
                    {
                        reader.Read(ref item.BoolVal);
                    }
                    else if (tagType == "ByteProperty")
                    {
                        reader.Read(item.EnumName);
                    }
                    else if (tagType == "EnumProperty")
                    {
                        reader.Read(item.EnumName);
                    }
                    else if (tagType == "ArrayProperty")
                    {
                        reader.Read(item.InnerType);
                    }
                    else if (tagType == "OptionalProperty")
                    {
                        reader.Read(item.InnerType);
                    }
                    else if (tagType == "SetProperty")
                    {
                        reader.Read(item.InnerType);
                    }
                    else if (tagType == "MapProperty")
                    {
                        reader.Read(item.InnerType);
                        reader.Read(item.ValueType);
                    }
                }

                reader.Read(ref item.HasPropertyGuid);
                if (item.HasPropertyGuid == 1)
                {
                    reader.Read(ref item.PropertyGuid);
                }
            }
            return item;
        }
    }
}
