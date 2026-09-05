namespace AssetTool
{
    [JsonAsset("SubUVAnimation")]
    public class USubUVAnimation : UObject
    {
        public bool bCooked;
        public FSubUVDerivedData DerivedData;

        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref bCooked);
            if (bCooked)
            {
                transfer.Move(ref DerivedData);
            }
            return this;
        }
    }

    public class FSubUVDerivedData : ITransferable
    {
        public List<FVector2f> BoundingGeometry;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref BoundingGeometry);
            return this;
        }
    }
}
