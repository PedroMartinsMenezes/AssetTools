namespace AssetTool
{
    public class FSoftObjectPtr : ITransferible
    {
        public FSoftObjectPath ObjectID = new();

        [Location("FArchive& FArchiveUObject::SerializeSoftObjectPtr(FArchive& Ar, FSoftObjectPtr& Value)")]
        public ITransferible Move(Transfer transfer)
        {
            ObjectID.Move(transfer);
            return this;
        }
    }
}
