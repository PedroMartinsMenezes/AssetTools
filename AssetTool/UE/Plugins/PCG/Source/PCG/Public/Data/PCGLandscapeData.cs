namespace AssetTool
{
    [JsonAsset("PCGLandscapeData")]
    public class UPCGLandscapeData : UPCGSurfaceData
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}