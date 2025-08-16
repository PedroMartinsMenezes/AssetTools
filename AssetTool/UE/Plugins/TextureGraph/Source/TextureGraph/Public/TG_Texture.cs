using System.Diagnostics;

namespace AssetTool
{
    [DebuggerDisplay("{TexturePath} {Descriptor}")]
    public class FTG_Texture : ITransferible
    {
        public FString TexturePath;
        public FTG_TextureDescriptor Descriptor;

        [Location("FArchive& operator<<(FArchive& Ar, FTG_Texture& T)")]
        public ITransferible Move(Transfer transfer)
        {
            if (transfer.Supports.TGTextureAddedTexturePath)
            {
                transfer.Move(ref TexturePath);
            }
            transfer.Move(ref Descriptor);
            return this;
        }

        [Location("void VarArchiveSerializer_FTG_Texture(FTG_Var::VarArchiveSerialInfo& Info)")]
        public object MoveValue(Transfer transfer, object value)
        {
            return value.ToObject<FSoftObjectPath>(transfer).Move(transfer);
        }
    }

    [DebuggerDisplay("{Width} {Height} {TextureFormat} {bIsSRGB}")]
    public class FTG_TextureDescriptor : ITransferible
    {
        public EResolution Width;
        public EResolution Height;
        public ETG_TextureFormat TextureFormat;
        public bool bIsSRGB;

        [Location("FArchive& operator<<(FArchive& Ar, FTG_TextureDescriptor& D)")]
        public ITransferible Move(Transfer transfer)
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
