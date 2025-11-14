namespace AssetTool
{
    [JsonAsset("LandscapeWeightPatchTextureInfo")]
    public class ULandscapeWeightPatchTextureInfo : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LandscapeTexturePatch")]
    public class ULandscapeTexturePatch : ULandscapePatchComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}