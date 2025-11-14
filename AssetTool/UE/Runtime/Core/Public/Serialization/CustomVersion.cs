namespace AssetTool
{
    public class FEnumCustomVersion_DEPRECATED : ITransferable
    {
        public uint32 Tag;
        public int32 Version;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Tag);
            transfer.Move(ref Version);
            return this;
        }
    }

    public class FGuidCustomVersion_DEPRECATED : ITransferable
    {
        public FGuid Key;
        public int32 Version;
        public FString FriendlyName;

        public ITransferable Move(Transfer transfer)
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
