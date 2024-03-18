namespace AssetTool
{
    [Location("void UK2Node_EditablePinBase::Serialize(FArchive& Ar)")]
    public class UK2Node_EditablePinBase : UK2Node
    {
        [Sized] public List<FUserPinInfo> SerializedItems;

        public new UK2Node_EditablePinBase Read(BinaryReader reader)
        {
            base.Read(reader);
            SerializedItems = [];
            int count = reader.ReadInt32();
            for (int i = 0; i < count; i++)
            {
                SerializedItems.Add(new FUserPinInfo().Read(reader));
            }
            return this;
        }
        public new void Write(BinaryWriter writer)
        {
            base.Write(writer);
            writer.Write(SerializedItems.Count);
            foreach (var userPinInfo in SerializedItems)
            {
                userPinInfo.Write(writer);
            }
        }
    }
}
