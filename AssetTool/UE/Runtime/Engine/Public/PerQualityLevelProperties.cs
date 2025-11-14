namespace AssetTool
{
    [TransferableStruct("PerQualityLevelInt")]
    public class FPerQualityLevelInt : FPerQualityLevelProperty
    {
        public ERayTracingPayloadType Default;
        public Dictionary<TInt32, TInt32> PerQuality;

        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.MoveEnum(ref Default);
            transfer.Move(ref PerQuality);
            return this;
        }
    }

    public class FPerQualityLevelProperty : ITransferable
    {
        public bool bCooked;

        public virtual ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref bCooked);
            return this;
        }
    }
}
