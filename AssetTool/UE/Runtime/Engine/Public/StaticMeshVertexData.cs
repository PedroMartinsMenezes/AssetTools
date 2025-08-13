namespace AssetTool
{
    public class TStaticMeshVertexData<T> : ITransferible, FStaticMeshVertexDataInterface where T : ITransferible, new()
    {
        public TBulkList<T> Items;

        [Location("void Serialize(FArchive& Ar, bool bForcePerElementSerialization = false) override")]
        public virtual ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Items);
            return this;
        }

        public virtual ITransferible Move(Transfer transfer, bool bForcePerElementSerialization)
        {
            Items ??= new();
            Items.Move(transfer, bForcePerElementSerialization);
            return this;
        }
    }
}
