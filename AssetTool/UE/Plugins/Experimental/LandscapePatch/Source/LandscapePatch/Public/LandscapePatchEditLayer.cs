namespace AssetTool
{
    [JsonAsset("LandscapePatchEditLayer")]
    public class ULandscapePatchEditLayer : ULandscapeEditLayerProcedural
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}