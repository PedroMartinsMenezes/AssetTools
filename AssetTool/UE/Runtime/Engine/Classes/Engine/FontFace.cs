namespace AssetTool
{
    [JsonAsset("FontFace")]
    public class UFontFace : UObject
    {
        public FBool bCooked;
        public FBool bLoadInlineData;
        public FFontFaceData FontFaceData;

        [Location("void UFontFace::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            if (Supports.AddedCookedBoolFontFaceAssets)
            {
                transfer.Move(ref bCooked);
            }
            if (Supports.AddedInlineFontFaceAssets)
            {
                transfer.Move(ref bLoadInlineData);
                if (bLoadInlineData)
                {
                    transfer.Move(ref FontFaceData);
                }
            }
            return this;
        }
    }
}