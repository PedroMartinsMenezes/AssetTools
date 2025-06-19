namespace AssetTool
{
    [TransferibleStruct("RemoteControlFunction")]
    public class FRemoteControlFunction : FRemoteControlField
    {
        public override ITransferible Move2(Transfer transfer)
        {
            return base.Move2(transfer);
        }
    }

    [TransferibleStruct("RemoteControlProperty")]
    public class FRemoteControlProperty : FRemoteControlField
    {
        public override ITransferible Move2(Transfer transfer)
        {
            return base.Move2(transfer);
        }
    }

    public class FRemoteControlField : FRemoteControlEntity
    {
        public override ITransferible Move2(Transfer transfer)
        {
            return base.Move2(transfer);
        }
    }
}