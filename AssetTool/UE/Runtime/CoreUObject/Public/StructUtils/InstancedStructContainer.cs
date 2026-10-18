namespace AssetTool
{
    [TransferableStruct("InstancedStructContainer")]
    public class FInstancedStructContainer : ITransferable
    {
        public EVersion Version;
        public int32 NumItemsSerialized;
        public UInt32[] NonConstStructAddresses;
        public Int32[] SerialSizes;
        public List<UScriptStruct> NonConstStructs;

        [Location("bool FInstancedStructContainer::Serialize(FArchive& Ar)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.MoveEnum(ref Version);
            if (Version > EVersion.LatestVersion)
            {
                return default;
            }
            transfer.Move(ref NumItemsSerialized);
            if (NumItemsSerialized > 0)
            {
                transfer.Resize(ref NonConstStructAddresses, NumItemsSerialized);
                transfer.Resize(ref SerialSizes, NumItemsSerialized);
                transfer.Resize(ref NonConstStructs, NumItemsSerialized);

                for (int32 Index = 0; Index < NumItemsSerialized; Index++)
                {
                    transfer.Move(ref NonConstStructAddresses[Index]);
                }
                for (int32 Index = 0; Index < NumItemsSerialized; Index++)
                {
                    transfer.Move(ref SerialSizes[Index]);
                    if (NonConstStructAddresses[Index] > 0)
                    {
                        NonConstStructs[Index].SerializeItem(transfer);
                    }
                }
            }
            return this;
        }
    }
}