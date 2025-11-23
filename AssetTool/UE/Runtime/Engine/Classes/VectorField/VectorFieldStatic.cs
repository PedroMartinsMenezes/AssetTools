namespace AssetTool
{
    [JsonAsset("VectorFieldStatic")]
    public class UVectorFieldStatic : UObject
    {
        public FByteBulkData SourceData;

        [Location("void UVectorFieldStatic::Serialize(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref SourceData);
            return this;
        }
    }
}