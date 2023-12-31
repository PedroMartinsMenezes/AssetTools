namespace AssetTool
{
    public struct FBool
    {
        public bool Value;

        public static implicit operator FBool(Int32 value) => new FBool { Value = value == 1 };
    }

    public static class FBoolExt
    {
        public static void Read(this BinaryReader reader, ref FBool item)
        {
            item.Value = reader.ReadInt32() == 1;
        }

        public static void Write(this BinaryWriter writer, FBool item)
        {
            writer.Write(item.Value ? 1 : 0);
        }
    }
}
