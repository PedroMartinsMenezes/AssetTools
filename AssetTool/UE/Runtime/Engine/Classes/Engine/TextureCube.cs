namespace AssetTool
{
    [JsonAsset("TextureCube")]
    public class UTextureCube : UTexture
    {
        public FStripDataFlags StripFlags2;
        public FBool bCooked;
        public List<FName> PixelFormatNames = [];
        public List<TInt64> SkipOffsets = [];

        [Location("void UTextureCube::Serialize(FArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
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
            int i = 0;

            if (PixelFormatNames.Count <= i)
                PixelFormatNames.Add(new FName());
            PixelFormatNames[i].Move(transfer);

            while (PixelFormatNames[i].IsFilled())
            {
                if (SkipOffsets.Count <= i)
                    SkipOffsets.Add(new());
                SkipOffsets[i].Move(transfer);

                i++;

                if (PixelFormatNames.Count <= i)
                    PixelFormatNames.Add(new FName());
                PixelFormatNames[i].Move(transfer);
            }
        }
    }
}
