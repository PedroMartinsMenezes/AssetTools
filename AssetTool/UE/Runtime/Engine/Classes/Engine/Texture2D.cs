
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
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);

            transfer.Move(ref StripDataFlags);

            transfer.Move(ref bCooked);

            ///if (bCooked.Value)
            ///{
            ///    transfer.Move(ref bSerializeMipData);
            ///    SerializeCookedPlatformData(transfer);
            ///}

            return this;
        }

        [Location("void UTexture::SerializeCookedPlatformData")]
        private void SerializeCookedPlatformData(Transfer transfer)
        {
            transfer.Move(ref PixelFormatName);

            throw new NotImplementedException();

            ///Ar << PixelFormatName;
            ///Ar << SkipOffset;
            ///PlatformDataToSave->SerializeCooked(Ar, this, bTextureIsStreamable, bSerializeMipData);
            ///Ar << SkipOffset;
            ///Ar << PixelFormatName;
        }
    }
}
