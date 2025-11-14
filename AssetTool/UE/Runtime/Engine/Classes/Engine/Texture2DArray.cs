
namespace AssetTool
{
    [JsonAsset("Texture2DArray")]
    public class UTexture2DArray : UTexture
    {
        public FStripDataFlags StripFlags2;
        public FBool bCooked;

        [Location("void UTexture2DArray::Serialize(FArchive& Ar)")]
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