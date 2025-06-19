namespace AssetTool
{
    [JsonAsset("Texture")]
    public class UTexture : UStreamableRenderAsset
    {
        public FStripDataFlags StripFlags;
        public FTextureSource Source;
        public FByteBulkData TempBulkData;

        [Location("void UTexture::Serialize(FArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);

            transfer.Move(ref StripFlags);

            if (!transfer.Supports.TextureSourceVirtualization)
            {
                transfer.Move(ref TempBulkData);
            }
            else
            {
                transfer.Move(ref Source);
            }

            return this;
        }
    }

    public class FTextureSource : ITransferible
    {
        public FEditorBulkData BulkData;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref BulkData);
            return this;
        }
    }
}
