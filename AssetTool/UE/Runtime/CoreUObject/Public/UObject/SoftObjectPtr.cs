namespace AssetTool
{
    public class FSoftObjectPtr : ITransferable
    {
        public UInt32 SoftObjectPtr;
        public FSoftObjectPath ObjectID;

        [Location("FArchive& FArchiveUObject::SerializeSoftObjectPtr(FArchive& Ar, FSoftObjectPtr& Value)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref ObjectID);
            return this;
        }

        public ITransferable MovePtr(Transfer transfer)
        {
            transfer.Move(ref SoftObjectPtr);
            return this;
        }
    }
}
