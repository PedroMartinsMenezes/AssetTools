namespace AssetTool
{
    [JsonAsset("SubUVAnimation")]
    public class USubUVAnimation : UObject
    {
        public FBool bCooked;
        public FSubUVDerivedData DerivedData;

        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref bCooked);
            if (bCooked ?? false)
            {
                transfer.Move(ref DerivedData);
            }
            return this;
        }
    }

    public class FSubUVDerivedData : ITransferible
    {
        public List<FVector2f> BoundingGeometry;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref BoundingGeometry);
            return this;
        }
    }
}
