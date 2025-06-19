namespace AssetTool
{
    [JsonAsset("VectorFieldStatic")]
    public class UVectorFieldStatic : UVectorField
    {
        public FByteBulkData SourceData;

        [Location("void UVectorFieldStatic::Serialize(FArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref SourceData);
            return this;
        }
    }
}