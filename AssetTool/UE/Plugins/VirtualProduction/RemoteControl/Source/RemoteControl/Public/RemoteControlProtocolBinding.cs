namespace AssetTool
{
    [TransferibleStruct("RemoteControlProtocolBinding")]
    public class FRemoteControlProtocolBinding : ITransferible
    {
        public ITransferible Move2(Transfer transfer)
        {
            throw new NotImplementedException();
        }
    }

    public class FRemoteControlProtocolEntity : ITransferible
    {
        public virtual ITransferible Move2(Transfer transfer)
        {
            throw new NotImplementedException();
        }
    }
}