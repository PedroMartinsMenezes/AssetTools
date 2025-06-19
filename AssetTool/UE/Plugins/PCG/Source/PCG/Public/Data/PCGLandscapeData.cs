namespace AssetTool
{
    [JsonAsset("PCGLandscapeData")]
    public class UPCGLandscapeData : UPCGSurfaceData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}