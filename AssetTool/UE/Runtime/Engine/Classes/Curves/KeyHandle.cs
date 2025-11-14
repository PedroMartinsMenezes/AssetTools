namespace AssetTool
{
    [TransferableStruct("KeyHandleMap")]
    public class FKeyHandleMap : ITransferable
    {
        [Location("bool FKeyHandleMap::Serialize(FArchive& Ar)")]
        public ITransferable Move(Transfer transfer)
        {
            return this;
        }
    }
}
