namespace AssetTool
{
    public class FTG_OutputSettings : ITransferable
    {
        public FName BaseName;
        public FName OutputName;
        public FName FolderPath;
        public EResolution Width;
        public EResolution Height;
        public ETG_TextureFormat TextureFormat;
        public ETG_TexturePresetType TexturePresetType;
        public TextureGroup LODGroup;
        public TextureCompressionSettings Compression;
        public bool bSRGB;

        [Location("FArchive& operator<<(FArchive& Ar, FTG_OutputSettings& T)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref BaseName);
            transfer.Move(ref OutputName);
            transfer.Move(ref FolderPath);
            transfer.MoveEnum(ref Width);
            transfer.MoveEnum(ref Height);
            transfer.MoveEnum(ref TextureFormat);
            transfer.MoveEnum(ref TexturePresetType);
            transfer.MoveEnum(ref LODGroup);
            transfer.MoveEnum(ref Compression);
            transfer.Move(ref bSRGB);
            return this;
        }
    }
}