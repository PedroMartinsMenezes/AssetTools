namespace AssetTool
{
    [JsonAsset("SparseVolumeTexture")]
    public class USparseVolumeTexture : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SparseVolumeTextureFrame")]
    public class USparseVolumeTextureFrame : USparseVolumeTexture
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

    [JsonAsset("StreamableSparseVolumeTexture")]
    public class UStreamableSparseVolumeTexture : USparseVolumeTexture
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("StaticSparseVolumeTexture")]
    public class UStaticSparseVolumeTexture : UStreamableSparseVolumeTexture
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AnimatedSparseVolumeTexture")]
    public class UAnimatedSparseVolumeTexture : UStreamableSparseVolumeTexture
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AnimatedSparseVolumeTextureController")]
    public class UAnimatedSparseVolumeTextureController : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
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