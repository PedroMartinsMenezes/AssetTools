namespace AssetTool
{
    public class ObjectDataResourceList : ITransferable
    {
        public int Offset;
        public uint32 Version;
        public int32 Count;
        public List<FObjectDataResource> ObjectDataResources;

        public ObjectDataResourceList(int offset)
        {
            Offset = offset;
        }

        public ObjectDataResourceList() { }

        public ITransferable Move(Transfer transfer)
        {
            if (Offset <= 0)
                return this;
            transfer.Move(ref Version);
            transfer.Move(ref Count);
            transfer.Move(ref ObjectDataResources, Count, (objectDataResource) =>
            {
                objectDataResource.Move(transfer, Version);
            });
            return this;
        }
    }
}
