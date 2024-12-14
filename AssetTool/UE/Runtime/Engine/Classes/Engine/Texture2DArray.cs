
namespace AssetTool
{
    [JsonAsset("Texture2DArray")]
    public class UTexture2DArray : UTexture
    {
        public new FStripDataFlags StripFlags;
        public FBool bCooked;

        [Location("void UTexture2DArray::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref StripFlags);
            transfer.Move(ref bCooked);
            if (bCooked)
            {
                SerializeCookedPlatformData(transfer);
            }
            return this;
        }

        [Location("void UTexture::SerializeCookedPlatformData(FArchive& Ar, const bool bSerializeMipData)")]
        private void SerializeCookedPlatformData(Transfer transfer)
        {
            throw new NotImplementedException();
        }
    }
}