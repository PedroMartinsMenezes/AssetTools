namespace AssetTool
{
    [Location("void UProperty::Serialize( FArchive& Ar )")]
    public class UProperty : UField
    {
        public UInt32 ArrayDim;
        public UInt64 SaveFlags;
        public FName RepNotifyFunc;
        public byte BlueprintReplicationCondition;

        public UProperty Read(BinaryReader reader)
        {
            base.Move(GlobalObjects.Transfer);

            reader.Read(ref ArrayDim);
            reader.Read(ref SaveFlags);
            reader.Read(ref RepNotifyFunc);
            if (GlobalObjects.CustomVer(FReleaseObjectVersion.Guid) >= (int)FReleaseObjectVersion.Enums.PropertiesSerializeRepCondition)
            {
                reader.Read(ref BlueprintReplicationCondition);
            }
            return this;
        }

        public void Write(BinaryWriter writer)
        {
            base.Move(GlobalObjects.Transfer);

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
