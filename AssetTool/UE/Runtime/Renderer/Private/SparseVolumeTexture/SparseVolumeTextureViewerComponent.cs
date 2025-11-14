namespace AssetTool
{
    [JsonAsset("SparseVolumeTextureViewerComponent")]
    public class USparseVolumeTextureViewerComponent : UPrimitiveComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SparseVolumeTextureViewer")]
    public class ASparseVolumeTextureViewer : AInfo
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}