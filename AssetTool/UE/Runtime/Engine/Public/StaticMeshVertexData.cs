namespace AssetTool
{
    public class TStaticMeshVertexData<T> : FStaticMeshVertexDataInterface where T : ITransferable, new()
    {
        public TBulkList<T> Items;

        [Location("void Serialize(FArchive& Ar, bool bForcePerElementSerialization = false) override")]
        public virtual ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Items);
            return this;
        }

        public virtual ITransferable Move(Transfer transfer, bool bForcePerElementSerialization)
        {
            Items ??= new();
            Items.Move(transfer, bForcePerElementSerialization);
            return this;
        }
    }
}
