namespace AssetTool
{
    [TransferableStruct("RemoteControlFunction")]
    public class FRemoteControlFunction : FRemoteControlField
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [TransferableStruct("RemoteControlProperty")]
    public class FRemoteControlProperty : FRemoteControlField
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    public class FRemoteControlField : FRemoteControlEntity
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}