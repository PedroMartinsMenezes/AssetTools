namespace AssetTool
{
    [JsonAsset("CADKernelParametricSurfaceData")]
    public class UCADKernelParametricSurfaceData : UDatasmithParametricSurfaceData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}