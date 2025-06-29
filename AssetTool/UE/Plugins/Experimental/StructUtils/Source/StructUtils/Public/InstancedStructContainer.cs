namespace AssetTool
{
    [TransferibleStruct("InstancedStructContainer")]
    public class FInstancedStructContainer : ITransferible
    {
        public EVersion Version;
        public int32 NumItemsSerialized;
        public List<UInt32> NonConstStructAddresses;
        public List<Int32> SerialSizes;
        public List<UScriptStruct> NonConstStructs;

        [Location("bool FInstancedStructContainer::Serialize(FArchive& Ar)")]
        public ITransferible Move(Transfer transfer)
        {
            Version = (EVersion)transfer.Move((byte)Version);
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
                    NonConstStructAddresses[Index] = transfer.Move(NonConstStructAddresses[Index]);
                }
                for (int32 Index = 0; Index < NumItemsSerialized; Index++)
                {
                    SerialSizes[Index] = transfer.Move(SerialSizes[Index]);
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