using AssetTool.Model.Const;

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
            list.ForEach(writer.Write);
        }

        public static void Write(this BinaryWriter writer, FPropertyTag item)
        {
            writer.Write(item.Name); //2879..2887
            if (item.Name.Value != "None")
            {
                //"ObjectProperty"
                writer.Write(item.Type); //2887..2895
                //4
                writer.Write(item.Size); //2895..2899
                //0
                writer.Write(item.ArrayIndex); //2899..2903

                writer.WriteExtra1(item);

                writer.Write(item.HasPropertyGuid); //2903..2904

                writer.Write(item.Value);
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
                if (tag.Name.Value != "None")
                {
                    tag.Value.Name = tag.Name.Value;
                    tag.Value.Type = tag.Type.Value;
                    tag.Value.Size = tag.Size;
                    reader.Read(tag.Value);
                }
            }
            while (tag.Name.Value != "None");
        }

        public static FPropertyTag Read(this BinaryReader reader, FPropertyTag tag)
        {
            ///Slot << SA_ATTRIBUTE(TEXT("Name"), Tag.Name);
            reader.Read(tag.Name);
            if (tag.Name.Value != "None")
            {
                ///Slot << SA_ATTRIBUTE(TEXT("Type"), Tag.Type);
                reader.Read(tag.Type);

                ///Slot << SA_ATTRIBUTE(TEXT("Size"), Tag.Size);
                reader.Read(ref tag.Size);

                ///Slot << SA_ATTRIBUTE(TEXT("ArrayIndex"), Tag.ArrayIndex);
                reader.Read(ref tag.ArrayIndex);

                reader.ReadExtra1(tag);

                ///Slot << SA_ATTRIBUTE(TEXT("HasPropertyGuid"), Tag.HasPropertyGuid);
                reader.Read(ref tag.HasPropertyGuid);
            }
            return tag;
        }

        public static FPropertyTag ReadExtra1(this BinaryReader reader, FPropertyTag tag)
        {
            if (tag.Type.Number == 0)
            {
                if (tag.Type.Value == Consts.StructProperty)
                {
                    ///Slot << SA_ATTRIBUTE(TEXT("StructName"), Tag.StructName);
                    reader.Read(tag.StructName);             //+8
                    ///Slot << SA_ATTRIBUTE(TEXT("StructGuid"), Tag.StructGuid);
                    reader.Read(ref tag.StructGuid);   //+16
                }
                else if (tag.Type.Value == Consts.BoolProperty)
                {
                    reader.Read(ref tag.BoolVal);      //+1
                }
                else if (tag.Type.Value == Consts.ByteProperty)
                {
                    reader.Read(tag.EnumName);         //+8
                }
                else if (tag.Type.Value == Consts.EnumProperty)
                {
                    reader.Read(tag.EnumName);         //+8
                }
                else if (tag.Type.Value == Consts.ArrayProperty)
                {
                    reader.Read(tag.InnerType);        //+8 None
                }
                else if (tag.Type.Value == Consts.OptionalProperty)
                {
                    reader.Read(tag.InnerType);        //+8
                }
                else if (tag.Type.Value == Consts.SetProperty)
                {
                    reader.Read(tag.InnerType);        //+8
                }
                else if (tag.Type.Value == Consts.MapProperty)
                {
                    reader.Read(tag.InnerType);        //+8
                    reader.Read(tag.ValueType);        //+8
                }
            }
            return tag;
        }

        public static void WriteExtra1(this BinaryWriter writer, FPropertyTag item)
        {
            if (item.Type.Number == 0)
            {
                if (item.Type.Value == Consts.StructProperty)
                {
                    writer.Write(item.Name);
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
}
