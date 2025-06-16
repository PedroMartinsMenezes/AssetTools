namespace AssetTool
{
    [JsonAsset("PCGLandscapeSplineData")]
    public class UPCGLandscapeSplineData : UPCGPolyLineData
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}