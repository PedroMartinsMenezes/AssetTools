namespace AssetTool
{
    [JsonAsset("PCGLandscapeSplineData")]
    public class UPCGLandscapeSplineData : UPCGPolyLineData
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}