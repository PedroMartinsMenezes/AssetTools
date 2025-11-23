namespace AssetTool
{
    [JsonAsset("SparseVolumeTextureFrame")]
    public class USparseVolumeTextureFrame : UObject
    {
        public FEditorBulkData SourceData;
        public FBool bCooked;
        public FResources Resources;

        [Location("void USparseVolumeTextureFrame::Serialize(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref SourceData);
            transfer.Move(ref bCooked);
            if (bCooked)
            {
                transfer.Move(ref Resources);
            }
            return this;
        }
    }

    public class FResources : ITransferable
    {
        [Location("void FResources::Serialize(FArchive& Ar, UObject* Owner, bool bCooked)")]
        public ITransferable Move(Transfer transfer)
        {
            throw new NotImplementedException();
        }
    }
}