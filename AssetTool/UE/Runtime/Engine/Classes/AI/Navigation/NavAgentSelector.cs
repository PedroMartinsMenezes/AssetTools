namespace AssetTool
{
    [TransferibleStruct("NavAgentSelector")]
    public class FNavAgentSelector : ITransferible
    {
        public uint32 PackedBits;

        [Location("bool FNavAgentSelector::Serialize(FArchive& Ar)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref PackedBits);
            return this;
        }
    }
}
