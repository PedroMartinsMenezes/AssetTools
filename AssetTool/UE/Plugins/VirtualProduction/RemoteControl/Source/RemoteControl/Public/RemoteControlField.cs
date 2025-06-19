namespace AssetTool
{
    [TransferibleStruct("RemoteControlFunction")]
    public class FRemoteControlFunction : FRemoteControlField
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [TransferibleStruct("RemoteControlProperty")]
    public class FRemoteControlProperty : FRemoteControlField
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    public class FRemoteControlField : FRemoteControlEntity
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}