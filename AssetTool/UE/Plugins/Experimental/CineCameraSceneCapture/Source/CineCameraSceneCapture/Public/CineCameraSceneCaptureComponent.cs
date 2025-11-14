namespace AssetTool
{
    [JsonAsset("CineCaptureComponent2D")]
    public class UCineCaptureComponent2D : USceneCaptureComponent2D
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}