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

            StripFlags.Move(transfer);

            if (!Supports.CustomVer(FUE5MainStreamObjectVersion.Enums.TextureSourceVirtualization))
            {
                TempBulkData ??= new();
                TempBulkData.Move(transfer);
            }
            else
            {
                Source.BulkData.Move(transfer);
            }

            return this;
        }
    }

    public class FTextureSource
    {
        public FEditorBulkData BulkData = new();
    }
}
