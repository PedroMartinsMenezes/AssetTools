namespace AssetTool
{
    [JsonAsset("VolumeTexture")]
    public class UVolumeTexture : UTexture
    {
        public new FStripDataFlags StripFlags;
        public FBool bCooked;

        [Location("void UVolumeTexture::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref StripFlags);
            transfer.Move(ref bCooked);
            if (bCooked ?? false)
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
