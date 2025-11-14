namespace AssetTool
{
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
}
