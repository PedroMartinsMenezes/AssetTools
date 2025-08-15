namespace AssetTool
{
    [TransferibleStruct("KeyHandleMap")]
    public class FKeyHandleMap : ITransferible
    {
        [Location("bool FKeyHandleMap::Serialize(FArchive& Ar)")]
        public ITransferible Move(Transfer transfer)
        {
            return this;
        }
    }
}
