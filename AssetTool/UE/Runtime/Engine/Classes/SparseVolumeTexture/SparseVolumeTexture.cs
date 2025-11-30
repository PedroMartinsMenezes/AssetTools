namespace AssetTool
{
    [JsonAsset("SparseVolumeTextureFrame")]
    public class USparseVolumeTextureFrame : UObject
    {
        public FEditorBulkData SourceData;
        public FBool bCooked;

        [Location("void USparseVolumeTextureFrame::Serialize(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref SourceData);
            transfer.Move(ref bCooked);
            if (bCooked)
            {
                throw new NotImplementedException();
                ///transfer.Move(ref Resources);
            }
            return this;
        }
    }
}