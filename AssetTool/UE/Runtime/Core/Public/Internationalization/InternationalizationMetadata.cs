namespace AssetTool
{
    public enum ELocMetadataType
    {
        None,
        Boolean,
        String,
        Array,
        Object,
    }

    public class FLocMetadataValueArray : ITransferible
    {
        public List<FLocMetadataValue> Values;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Values);
            return this;
        }
    }

    public class FLocMetadataValueBoolean : ITransferible
    {
        public FBool FBool;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref FBool);
            return this;
        }
    }

    public class FLocMetadataValueObject : ITransferible
    {
        public UInt32 Value;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Value);
            return this;
        }
    }

    public class FLocMetadataValueString : ITransferible
    {
        public FString Value;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Value);
            return this;
        }
    }
}
