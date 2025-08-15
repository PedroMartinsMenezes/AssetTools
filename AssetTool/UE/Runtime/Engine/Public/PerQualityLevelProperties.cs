namespace AssetTool
{
    [TransferibleStruct("PerQualityLevelInt")]
    public class FPerQualityLevelInt : FPerQualityLevelProperty
    {
        public ERayTracingPayloadType Default;
        public Dictionary<TInt32, TInt32> PerQuality;

        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.MoveEnum(ref Default);
            transfer.Move(ref PerQuality);
            return this;
        }
    }

    public class FPerQualityLevelProperty : ITransferible
    {
        public bool bCooked;

        public virtual ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref bCooked);
            return this;
        }
    }
}
