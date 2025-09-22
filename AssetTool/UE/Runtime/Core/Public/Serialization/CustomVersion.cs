namespace AssetTool
{
    public class FEnumCustomVersion_DEPRECATED : ITransferible
    {
        public uint32 Tag;
        public int32 Version;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Tag);
            transfer.Move(ref Version);
            return this;
        }
    }

    public class FGuidCustomVersion_DEPRECATED : ITransferible
    {
        public FGuid Key;
        public int32 Version;
        public FString FriendlyName;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Key);
            transfer.Move(ref Version);
            transfer.Move(ref FriendlyName);
            return this;
        }
    }

    public enum ECustomVersionSerializationFormat : uint8
    {
        Unknown,
        Guids,
        Enums,
        Optimized,
    }
}
