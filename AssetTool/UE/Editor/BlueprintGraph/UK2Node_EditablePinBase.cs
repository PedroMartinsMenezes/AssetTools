namespace AssetTool
{
    [Location("void UK2Node_EditablePinBase::Serialize(FArchive& Ar)")]
    public class UK2Node_EditablePinBase : UK2Node
    {
        [Sized] public List<FUserPinInfo> SerializedItems;
    }

    public static class UK2Node_EditablePinBaseExt
    {
        public static void Write(this BinaryWriter writer, UK2Node_EditablePinBase item)
        {
            writer.Write((UK2Node)item);
            writer.Write(item.SerializedItems.Count);
            foreach (var userPinInfo in item.SerializedItems)
            {
                writer.Write(userPinInfo);
            }
        }

        public static UK2Node_EditablePinBase Read(this BinaryReader reader, UK2Node_EditablePinBase item)
        {
            reader.Read((UK2Node)item);
            item.SerializedItems = new();
            int count = reader.ReadInt32();
            for (int i = 0; i < count; i++)
            {
                item.SerializedItems.Add(reader.Read(new FUserPinInfo()));
            }
            return item;
        }
    }
}
