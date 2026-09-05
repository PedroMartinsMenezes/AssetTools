namespace AssetTool
{
    public class FDataflowOutput : FDataflowConnection
    {
        public bool bIsAnyType;
        public bool bIsHidden;

        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            if (transfer.Supports.DataflowAnyTypeSupport)
            {
                transfer.Move(ref bIsAnyType);
            }
            if (transfer.Supports.DataflowHideablePins)
            {
                transfer.Move(ref bIsHidden);
            }
            return this;
        }
    }

    public class FDataflowInput : FDataflowConnection
    {
        public bool bIsAnyType;
        public bool bIsHidden;

        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            if (transfer.Supports.DataflowAnyTypeSupport)
            {
                transfer.Move(ref bIsAnyType);
            }
            if (transfer.Supports.DataflowHideablePins)
            {
                transfer.Move(ref bIsHidden);
            }
            return this;
        }
    }
}