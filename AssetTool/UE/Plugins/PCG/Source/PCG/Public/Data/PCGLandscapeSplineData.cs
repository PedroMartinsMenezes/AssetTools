namespace AssetTool
{
    [JsonAsset("PCGLandscapeSplineData")]
    public class UPCGLandscapeSplineData : UPCGPolyLineData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}