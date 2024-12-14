namespace AssetTool
{
    [JsonAsset("SparseVolumeTexture")]
    public class USparseVolumeTexture : UObject
    {
        public override UObject Move(Transfer transfer)
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
        public override UObject Move(Transfer transfer)
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
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("StaticSparseVolumeTexture")]
    public class UStaticSparseVolumeTexture : UStreamableSparseVolumeTexture
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AnimatedSparseVolumeTexture")]
    public class UAnimatedSparseVolumeTexture : UStreamableSparseVolumeTexture
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AnimatedSparseVolumeTextureController")]
    public class UAnimatedSparseVolumeTextureController : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    public class FResources : ITransferible
    {
        [Location("void FResources::Serialize(FArchive& Ar, UObject* Owner, bool bCooked)")]
        public ITransferible Move(Transfer transfer)
        {
            throw new NotImplementedException();
        }
    }
}