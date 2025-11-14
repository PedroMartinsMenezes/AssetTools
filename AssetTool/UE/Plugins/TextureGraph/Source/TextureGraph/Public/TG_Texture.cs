using System.Diagnostics;

namespace AssetTool
{
    [DebuggerDisplay("{TexturePath} {Descriptor}")]
    public class FTG_Texture : ITransferable
    {
        public FString TexturePath;
        public FTG_TextureDescriptor Descriptor;

        [Location("FArchive& operator<<(FArchive& Ar, FTG_Texture& T)")]
        public ITransferable Move(Transfer transfer)
        {
            if (transfer.Supports.TGTextureAddedTexturePath)
            {
                transfer.Move(ref TexturePath);
            }
            transfer.Move(ref Descriptor);
            return this;
        }
    }

    [DebuggerDisplay("{Width} {Height} {TextureFormat} {bIsSRGB}")]
    public class FTG_TextureDescriptor : ITransferable
    {
        public EResolution Width;
        public EResolution Height;
        public ETG_TextureFormat TextureFormat;
        public bool bIsSRGB;

        [Location("FArchive& operator<<(FArchive& Ar, FTG_TextureDescriptor& D)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.MoveEnum(ref Width);
            transfer.MoveEnum(ref Height);
            transfer.MoveEnum(ref TextureFormat);
            if (transfer.Supports.TGTextureDescAdded_bSRGB)
            {
                transfer.Move(ref bIsSRGB);
            }
            return this;
        }
    }
}
