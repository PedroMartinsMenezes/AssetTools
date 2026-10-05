namespace AssetTool
{
    public class FLocMetadataValue : ITransferable
    {
        public ELocMetadataType MetaDataType;
        public FLocMetadataValueArray ValueArray;
        public FLocMetadataValueBoolean ValueBoolean;
        public FLocMetadataValueObject ValueObject;
        public FLocMetadataValueString ValueString;

        public ITransferable Move(Transfer transfer)
        {
            transfer.MoveEnum(ref MetaDataType);
            switch (MetaDataType)
            {
                case ELocMetadataType.Array:
                    transfer.Move(ref ValueArray);
                    break;
                case ELocMetadataType.Boolean:
                    transfer.Move(ref ValueBoolean);
                    break;
                case ELocMetadataType.Object:
                    transfer.Move(ref ValueObject);
                    break;
                case ELocMetadataType.String:
                    transfer.Move(ref ValueString);
                    break;
            }
            return this;
        }
    }

    public class FLocMetadataObject : ITransferable
    {
        public Dictionary<FString, FLocMetadataValue> Values;

        [Location("void operator<<(FStructuredArchive::FSlot Slot, FLocMetadataObject& Object)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Values);
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

    public class FLocMetadataValueBoolean : ITransferable
    {
        public bool Value;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Value);
            return this;
        }
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

    public class FLocMetadataValueObject : ITransferable
    {
        public UInt32 Value;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Value);
            return this;
        }
    }

    public enum ELocMetadataType : UInt32
    {
        None,
        Boolean,
        String,
        Array,
        Object,
    }
}
