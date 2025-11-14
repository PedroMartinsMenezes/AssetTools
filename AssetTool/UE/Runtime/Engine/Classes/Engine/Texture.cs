namespace AssetTool
{
    [JsonAsset("Texture")]
    public class UTexture : UStreamableRenderAsset
    {
        public FStripDataFlags StripFlags;
        public FTextureSource Source;
        public FByteBulkData TempBulkData;

        [Location("void UTexture::Serialize(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
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

    public class FTextureSource : ITransferable
    {
        public FEditorBulkData BulkData;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref BulkData);
            return this;
        }
    }
}
