namespace AssetTool
{
    [Location("void FProperty::Serialize( FArchive& Ar )")]
    public class FProperty : FField
    {
        public override string TypeName => "FProperty";

        public Int32 ArrayDim;
        public Int32 ElementSize;
        public UInt64 PropertyFlags;
        public UInt16 RepIndex;
        public FName RepNotifyFunc;
        public byte BlueprintReplicationCondition;

        public void Read(BinaryReader reader, List<FProperty> list)
        {
            list.Resize(reader.ReadInt32());
            list.ForEach(x => x.Read(reader));
        }

        public new FProperty Read(BinaryReader reader)
        {
            base.Read(reader);

            reader.Read(ref ArrayDim);
            reader.Read(ref ElementSize);
            reader.Read(ref PropertyFlags);
            reader.Read(ref RepIndex);
            reader.Read(ref RepNotifyFunc);
            reader.Read(ref BlueprintReplicationCondition);

            return this;
        }

        public void Write(BinaryWriter writer, List<FProperty> list)
        {
            writer.Write(list.Count);
            list.ForEach(x => x.Write(writer));
        }

        public new void Write(BinaryWriter writer)
        {
            base.Write(writer);

            writer.Write(ArrayDim);
            writer.Write(ElementSize);
            writer.Write(PropertyFlags);
            writer.Write(RepIndex);
            writer.Write(RepNotifyFunc);
            writer.Write(BlueprintReplicationCondition);
        }
    }
}
