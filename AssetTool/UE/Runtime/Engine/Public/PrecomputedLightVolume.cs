namespace AssetTool
{
    public class FPrecomputedLightVolumeData : ITransferible
    {
        public FBool bValid;
        public FBool bVolumeInitialized;
        public FBox Bounds;

        [Location("FArchive& operator<<(FArchive& Ar, FPrecomputedLightVolumeData*& Volume)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref bValid);
            if (bValid ?? false)
            {
                transfer.Move(ref bVolumeInitialized);
                if (bVolumeInitialized ?? false)
                {
                    throw new NotImplementedException();
                }
            }
            return this;
        }
    }
}
