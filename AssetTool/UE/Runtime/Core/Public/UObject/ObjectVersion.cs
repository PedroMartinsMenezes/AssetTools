namespace AssetTool
{
    public static class ObjectVersion
    {
        public const uint PACKAGE_FILE_TAG = 0x9E2A83C1;
        public const uint PACKAGE_FILE_TAG_SWAPPED = 0xC1832A9E;
    }

    public enum EUnrealEngineObjectLicenseeUEVersion
    {
        VER_LIC_NONE = 0,

        VER_LIC_AUTOMATIC_VERSION_PLUS_ONE,
        VER_LIC_AUTOMATIC_VERSION = VER_LIC_AUTOMATIC_VERSION_PLUS_ONE - 1
    }

    public static partial class Consts
    {
        public readonly static FPackageFileVersion GPackageFileUEVersion = new()
        {
            FileVersionUE4 = EUnrealEngineObjectUE4Version.VER_UE4_AUTOMATIC_VERSION,
            FileVersionUE5 = EUnrealEngineObjectUE5Version.AUTOMATIC_VERSION
        };

        public readonly static EUnrealEngineObjectLicenseeUEVersion GPackageFileLicenseeUEVersion = EUnrealEngineObjectLicenseeUEVersion.VER_LIC_AUTOMATIC_VERSION;
    }
}
