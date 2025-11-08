namespace AssetTool
{
    [JsonAsset("FontBulkData")]
    public class UFontBulkData : UObject
    {
        public FByteBulkData BulkData;

        [Location("void UFontBulkData::Serialize(FArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);

            transfer.Move(ref BulkData);

            return this;
        }
    }
}