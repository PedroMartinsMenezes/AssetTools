namespace AssetTool
{
    public enum ELocMetadataType : UInt32
    {
        None,
        Boolean,
        String,
        Array,
        Object,
    }

    public class FLocMetadataValueArray : ITransferable
    {
        public List<FLocMetadataValue> Values;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Values);
            return this;
        }
    }

    public class FLocMetadataValueBoolean : ITransferable
    {
        public bool Value;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Value);
            return this;
        }
    }

    public class FLocMetadataValueObject : ITransferable
    {
        public UInt32 Value;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Value);
            return this;
        }
    }

    public class FLocMetadataValueString : ITransferable
    {
        public FString Value;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Value);
            return this;
        }
    }
}
