namespace AssetTool
{
    [TransferibleStruct("RemoteControlDMXProtocolEntity")]
    public class FRemoteControlDMXProtocolEntity : FRemoteControlProtocolEntity
    {
        public override ITransferible Move2(Transfer transfer)
        {
            return base.Move2(transfer);
        }
    }
}