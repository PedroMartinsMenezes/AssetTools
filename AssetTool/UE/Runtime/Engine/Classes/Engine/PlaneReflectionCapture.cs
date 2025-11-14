namespace AssetTool
{
    [JsonAsset("PlaneReflectionCapture")]
    public class APlaneReflectionCapture : AReflectionCapture
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}