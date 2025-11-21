namespace AssetTool
{
    public class FPerQualityLevelProperty : ITransferable
    {
        public bool bCooked;

        public virtual ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref bCooked);
            return this;
        }
    }

    [TransferableStruct("PerQualityLevelInt")]
    public class FPerQualityLevelInt : FPerQualityLevelProperty
    {
        public Int32 Default;
        public Dictionary<TInt32, TInt32> PerQuality;

        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.MoveEnum(ref Default);
            transfer.Move(ref PerQuality);
            return this;
        }
    }

    [TransferableStruct("PerQualityLevelFloat")]
    public class FPerQualityLevelFloat : FPerQualityLevelProperty
    {
        public float Default;
        public Dictionary<TInt32, TFloat> PerQuality;

        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.MoveEnum(ref Default);
            transfer.Move(ref PerQuality);
            return this;
        }
    }
}
