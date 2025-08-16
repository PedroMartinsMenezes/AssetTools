namespace AssetTool
{
    public enum EResolution : uint32
    {
        Auto = 0,
        Resolution8 = 8,
        Resolution16 = 16,
        Resolution32 = 32,
        Resolution64 = 64,
        Resolution128 = 128,
        Resolution256 = 256,
        Resolution512 = 512,
        Resolution1024 = 1024,
        Resolution2048 = 2048,
        Resolution4096 = 4096,
        Resolution8192 = 8192
    }

    public enum ETG_TextureFormat : uint8
    {
        Auto,
        G8,
        BGRA8,
        R16F,
        RGBA16F,
        R32F,
        RGBA32F
    }

    public enum ETG_TexturePresetType : uint8
    {
        None,
        Diffuse,
        Emissive,
        FX,
        Normal,
        MaskComp,
        Specular,
        Tangent,
    }
}
