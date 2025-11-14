namespace AssetTool
{
    [JsonAsset("CADKernelParametricSurfaceData")]
    public class UCADKernelParametricSurfaceData : UDatasmithParametricSurfaceData
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}