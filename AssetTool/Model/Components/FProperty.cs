namespace AssetTool
{
    [Location("void FProperty::Serialize( FArchive& Ar )")]
    public class FProperty : FField
    {
        public Int32 ArrayDim;
        public Int32 ElementSize;
        public UInt64 PropertyFlags;
        public UInt16 RepIndex;
        public FName RepNotifyFunc = new();
        public byte BlueprintReplicationCondition;
    }

    public static class FPropertyExt
    {
        public static void Write(this BinaryWriter writer, List<FProperty> list)
        {
            writer.Write(list.Count);
            list.ForEach(writer.Write);
        }

        public static void Write(this BinaryWriter writer, FProperty item)
        {
            writer.Write((FField)item);

            writer.Write(item.ArrayDim);
            writer.Write(item.ElementSize);
            writer.Write(item.PropertyFlags);
            writer.Write(item.RepIndex);
            writer.Write(item.RepNotifyFunc);
            writer.Write(item.BlueprintReplicationCondition);
        }

        public static void Read(this BinaryReader reader, List<FProperty> list)
        {
            list.Resize(reader.ReadInt32());
            list.ForEach(reader.Read);
        }

        public static void Read(this BinaryReader reader, FProperty item)
        {
            reader.Read((FField)item);

            reader.Read(ref item.ArrayDim);
            reader.Read(ref item.ElementSize);
            reader.Read(ref item.PropertyFlags);
            reader.Read(ref item.RepIndex);
            reader.Read(item.RepNotifyFunc);
            reader.Read(ref item.BlueprintReplicationCondition);
        }
    }
}
