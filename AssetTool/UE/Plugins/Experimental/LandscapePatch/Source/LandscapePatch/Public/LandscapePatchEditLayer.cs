namespace AssetTool
{
    [JsonAsset("LandscapePatchEditLayer")]
    public class ULandscapePatchEditLayer : ULandscapeEditLayerProcedural
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}