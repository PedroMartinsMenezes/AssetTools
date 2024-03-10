namespace AssetTool
{
    [Location("void UProperty::Serialize( FArchive& Ar )")]
    public class UProperty : UField
    {
        public UInt32 ArrayDim;
        public UInt64 SaveFlags;
        public FName RepNotifyFunc;
        public byte BlueprintReplicationCondition;
    }

    public static class UPropertyExt
    {
        public static UProperty Read(this BinaryReader reader, UProperty item)
        {
            reader.Read((UField)item);

            reader.Read(ref item.ArrayDim);
            reader.Read(ref item.SaveFlags);
            reader.Read(ref item.RepNotifyFunc);
            if (GlobalObjects.CustomVer(FReleaseObjectVersion.Guid) >= (int)FReleaseObjectVersion.Enums.PropertiesSerializeRepCondition)
            {
                reader.Read(ref item.BlueprintReplicationCondition);
            }
            return item;
        }

        public static void Write(this BinaryWriter writer, UProperty item)
        {
            writer.Write((UField)item);

            writer.Write(item.ArrayDim);
            writer.Write(item.SaveFlags);
            writer.Write(item.RepNotifyFunc);
            if (GlobalObjects.CustomVer(FReleaseObjectVersion.Guid) >= (int)FReleaseObjectVersion.Enums.PropertiesSerializeRepCondition)
            {
                writer.Write(item.BlueprintReplicationCondition);
            }
        }
    }
}
