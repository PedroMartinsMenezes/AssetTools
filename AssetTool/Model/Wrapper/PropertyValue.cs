using AssetTool.Model.Const;

namespace AssetTool
{
    public class PropertyValue
    {
        public string Name;
        public string Type;
        public int Size;

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
    }

    public static class PropertyValueExt
    {
        public static void Write(this BinaryWriter writer, PropertyValue prop)
        {
            //check Name
            if (prop.Name is Consts.Guid or Consts.VarGuid)
                writer.Write(prop.Value_Guid);
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
            else if (prop.Type == Consts.PinValueType)
            {
                reader.Read(prop.Value_Children);
            }
            else if (prop.Type == Consts.ArrayProperty) //&& prop.InnerType.Value == Consts.StructProperty)
            {
                int count = reader.ReadInt32();
                prop.Value_ArrayProperty.Resize(count);

                FPropertyTag MaybeInnerTag = new();
                reader.Read(MaybeInnerTag);

                for (int i = 0; i < count; i++)
                {
                    List<FPropertyTag> list = prop.Value_ArrayProperty[i];
                    reader.Read(list);
                }
            }
            else if (prop.Size > 0)
            {
                throw new ArgumentException($"Invalid param: Type({prop.Type}) Name({prop.Name}) Size({prop.Size})");
            }
        }
    }
}
