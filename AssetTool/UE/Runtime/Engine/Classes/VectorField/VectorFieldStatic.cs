namespace AssetTool
{
    [JsonAsset("VectorFieldStatic")]
    public class UVectorFieldStatic : UVectorField
    {
        public FByteBulkData SourceData;

        [Location("void UVectorFieldStatic::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref SourceData);
            return this;
        }
    }
}