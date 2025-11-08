namespace AssetTool
{
    [TransferibleStruct("FontData")]
    public class FFontData : ITransferible
    {
        public FBool bIsCooked;
        public UInt32 FontFaceAsset;
        public FString FontFilename;
        public EFontHinting Hinting;
        public EFontLoadingPolicy LoadingPolicy;
        public UScriptStruct FontDataStruct;

        [Location("bool FFontData::Serialize(FArchive& Ar)")]
        public ITransferible Move(Transfer transfer)
        {
            if (!transfer.Supports.AddedFontFaceAssets)
            {
                return null;
            }
            transfer.Move(ref bIsCooked);
            if (bIsCooked)
            {
                transfer.Move(ref FontFaceAsset);
                if (FontFaceAsset == 0)
                {
                    transfer.Move(ref FontFilename);
                    transfer.MoveEnum(ref Hinting);
                    transfer.MoveEnum(ref LoadingPolicy);
                }
            }
            else
            {
                FontDataStruct ??= new();
                FontDataStruct.SerializeTaggedProperties(transfer);
            }
            return this;
        }
    }

    public class FFontFaceData : ITransferible
    {
        public byte[] Data;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Data);
            return this;
        }
    }

    public enum EFontHinting : byte
    {
        Default,
        Auto,
        AutoLight,
        Monochrome,
        None,
    }

    public enum EFontLoadingPolicy : byte
    {
        LazyLoad,
        Stream,
        Inline,
    }
}
