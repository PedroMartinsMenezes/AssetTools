namespace AssetTool
{
    public class FPCGMetadataAttribute<T> : FPCGMetadataAttributeBase where T : ITransferible, new()
    {
        public List<T> Values;
        public T DefaultValue;

        [Location("virtual void Serialize(UPCGMetadata* InMetadata, FArchive& InArchive) override")]
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref Values);
            transfer.Move(ref DefaultValue);
            return this;
        }
    }
}


