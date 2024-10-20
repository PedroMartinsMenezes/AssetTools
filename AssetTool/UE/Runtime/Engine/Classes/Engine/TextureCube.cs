
namespace AssetTool.UE.Runtime.Engine.Classes.Engine
{
    [JsonAsset("TextureCube")]
    public class UTextureCube : UTexture
    {
        public new FStripDataFlags StripFlags;
        public FBool bCooked;
        public List<FName> PixelFormatNames = [];
        public List<TInt64> SkipOffsets = [];

        [Location("void UTextureCube::Serialize(FArchive& Ar)")]
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
            int i = 0;

            if (PixelFormatNames.Count <= i)
                PixelFormatNames.Add(new());
            PixelFormatNames[i].Move(transfer);

            while (PixelFormatNames[i] != GlobalNames.None)
            {
                if (SkipOffsets.Count <= i)
                    SkipOffsets.Add(new());
                SkipOffsets[i].Move(transfer);

                i++;

                if (PixelFormatNames.Count <= i)
                    PixelFormatNames.Add(new());
                PixelFormatNames[i].Move(transfer);
            }
        }
    }
}
