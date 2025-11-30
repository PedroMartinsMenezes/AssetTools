
namespace AssetTool
{
    [JsonAsset("Texture2D")]
    public class UTexture2D : UTexture
    {
        public FBool bCooked;
        public FBool bSerializeMipData;
        public FName PixelFormatName;
        public FStripDataFlags StripDataFlags;

        [Location("void UTexture2D::Serialize(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);

            transfer.Move(ref StripDataFlags);

            transfer.Move(ref bCooked);

            if (bCooked.Value)
            {
                throw new NotImplementedException();
                ///    transfer.Move(ref bSerializeMipData);
                ///    SerializeCookedPlatformData(transfer);
            }

            return this;
        }
    }
}
