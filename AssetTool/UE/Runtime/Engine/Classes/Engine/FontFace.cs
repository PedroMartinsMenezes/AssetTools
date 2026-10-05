namespace AssetTool
{
    [JsonAsset("FontFace")]
    public class UFontFace : UObject
    {
        public bool bCooked;
        public bool bLoadInlineData;
        public FFontFaceData FontFaceData;

        [Location("void UFontFace::Serialize(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            if (transfer.Supports.AddedCookedBoolFontFaceAssets)
            {
                transfer.Move(ref bCooked);
            }
            if (transfer.Supports.AddedInlineFontFaceAssets)
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