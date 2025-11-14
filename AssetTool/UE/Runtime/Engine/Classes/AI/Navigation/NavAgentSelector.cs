namespace AssetTool
{
    [TransferableStruct("NavAgentSelector")]
    public class FNavAgentSelector : ITransferable
    {
        public uint32 PackedBits;

        [Location("bool FNavAgentSelector::Serialize(FArchive& Ar)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref PackedBits);
            return this;
        }
    }
}
