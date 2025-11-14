namespace AssetTool
{
    [TransferableStruct("InstancedStruct")]
    public class FInstancedStruct : ITransferable
    {
        public uint32 Header;
        public uint8 Version;
        public UInt32 NonConstStructAddress;
        public Int32 NonConstStructSerialSize;
        public UScriptStruct NonConstStruct = new();

        [Location("bool FInstancedStruct::Serialize(FArchive& Ar)")]
        public ITransferable Move(Transfer transfer)
        {
            if (!transfer.Supports.CustomVersionAdded)
            {
                transfer.Move(ref Header);
                transfer.Move(ref Version);
            }
            transfer.Move(ref NonConstStructAddress);
            transfer.Move(ref NonConstStructSerialSize);
            if (NonConstStructAddress > 0)
            {
                NonConstStruct.SerializeItem(transfer);
            }
            return this;
        }
    }
}