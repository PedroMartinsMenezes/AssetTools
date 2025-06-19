namespace AssetTool
{
    [TransferibleStruct("RemoteControlDMXProtocolEntity")]
    public class FRemoteControlDMXProtocolEntity : FRemoteControlProtocolEntity
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}