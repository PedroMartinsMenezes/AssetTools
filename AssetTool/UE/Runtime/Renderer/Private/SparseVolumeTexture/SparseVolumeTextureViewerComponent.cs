namespace AssetTool
{
    [JsonAsset("SparseVolumeTextureViewerComponent")]
    public class USparseVolumeTextureViewerComponent : UPrimitiveComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SparseVolumeTextureViewer")]
    public class ASparseVolumeTextureViewer : AInfo
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}