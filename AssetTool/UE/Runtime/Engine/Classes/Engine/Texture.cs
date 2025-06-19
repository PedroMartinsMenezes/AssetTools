namespace AssetTool
{
    [JsonAsset("Texture")]
    public class UTexture : UStreamableRenderAsset
    {
        public FStripDataFlags StripFlags = new();
        public FTextureSource Source = new();
        public FByteBulkData TempBulkData;

        [Location("void UTexture::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);

            StripFlags.Move2(transfer);

            if (!transfer.Supports.TextureSourceVirtualization)
            {
                TempBulkData ??= new();
                TempBulkData.Move2(transfer);
            }
            else
            {
                Source.BulkData.Move2(transfer);
            }

            return this;
        }
    }

    public class FTextureSource
    {
        public FEditorBulkData BulkData = new();
    }
}
