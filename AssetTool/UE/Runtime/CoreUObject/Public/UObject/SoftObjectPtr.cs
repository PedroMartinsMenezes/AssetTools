namespace AssetTool
{
    public class FSoftObjectPtr : ITransferible
    {
        public UInt32 SoftObjectPtr;
        public FSoftObjectPath ObjectID = new();

        [Location("FArchive& FArchiveUObject::SerializeSoftObjectPtr(FArchive& Ar, FSoftObjectPtr& Value)")]
        public ITransferible Move2(Transfer transfer)
        {
            ObjectID.Move2(transfer);
            return this;
        }

        public ITransferible MovePtr(Transfer transfer)
        {
            transfer.Move(ref SoftObjectPtr);
            return this;
        }
    }
}
