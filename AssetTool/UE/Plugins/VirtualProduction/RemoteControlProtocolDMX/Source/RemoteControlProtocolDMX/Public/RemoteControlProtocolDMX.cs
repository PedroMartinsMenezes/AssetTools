namespace AssetTool
{
    [TransferableStruct("RemoteControlDMXProtocolEntity")]
    public class FRemoteControlDMXProtocolEntity : FRemoteControlProtocolEntity
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}