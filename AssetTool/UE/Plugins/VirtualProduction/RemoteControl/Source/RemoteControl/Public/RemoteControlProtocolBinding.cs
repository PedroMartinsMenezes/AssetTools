namespace AssetTool
{
    [TransferableStruct("RemoteControlProtocolBinding")]
    public class FRemoteControlProtocolBinding : ITransferable
    {
        public ITransferable Move(Transfer transfer)
        {
            throw new NotImplementedException();
        }
    }

    public class FRemoteControlProtocolEntity : ITransferable
    {
        public virtual ITransferable Move(Transfer transfer)
        {
            throw new NotImplementedException();
        }
    }
}