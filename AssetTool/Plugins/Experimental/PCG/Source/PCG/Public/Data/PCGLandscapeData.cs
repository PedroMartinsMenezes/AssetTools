namespace AssetTool
{
    [JsonAsset("PCGLandscapeData")]
    public class UPCGLandscapeData : UPCGSurfaceData
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}