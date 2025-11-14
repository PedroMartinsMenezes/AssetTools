namespace AssetTool
{
    [JsonAsset("VolumeTexture")]
    public class UVolumeTexture : UTexture
    {
        public FStripDataFlags StripFlags2;
        public FBool bCooked;

        [Location("void UVolumeTexture::Serialize(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref StripFlags2);
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
