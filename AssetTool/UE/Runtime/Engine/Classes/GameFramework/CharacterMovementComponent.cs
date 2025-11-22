namespace AssetTool
{
    [TransferableStruct("NavMovementComponentVersion")]
    public class NavMovementComponentVersion : ITransferable
    {
        public byte Value;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Value);
            return this;
        }
    }
}