namespace AssetTool
{
    public class ObjectDataResourceList : ITransferable
    {
        public uint32 Version;
        public int32 Count;
        public List<FObjectDataResource> ObjectDataResources;

        public ObjectDataResourceList() { }

        public ITransferable Move(Transfer transfer)
        {
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
