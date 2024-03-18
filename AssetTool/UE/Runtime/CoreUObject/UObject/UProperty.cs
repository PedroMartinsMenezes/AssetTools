namespace AssetTool
{
    [Location("void UProperty::Serialize( FArchive& Ar )")]
    public class UProperty : UField
    {
        public UInt32 ArrayDim;
        public UInt64 SaveFlags;
        public FName RepNotifyFunc;
        public byte BlueprintReplicationCondition;

        public new UProperty Read(BinaryReader reader)
        {
            base.Read(reader);

            reader.Read(ref ArrayDim);
            reader.Read(ref SaveFlags);
            reader.Read(ref RepNotifyFunc);
            if (GlobalObjects.CustomVer(FReleaseObjectVersion.Guid) >= (int)FReleaseObjectVersion.Enums.PropertiesSerializeRepCondition)
            {
                reader.Read(ref BlueprintReplicationCondition);
            }
            return this;
        }

        public new void Write(BinaryWriter writer)
        {
            base.Write(writer);

            writer.Write(ArrayDim);
            writer.Write(SaveFlags);
            writer.Write(RepNotifyFunc);
            if (GlobalObjects.CustomVer(FReleaseObjectVersion.Guid) >= (int)FReleaseObjectVersion.Enums.PropertiesSerializeRepCondition)
            {
                writer.Write(BlueprintReplicationCondition);
            }
        }
    }
}
