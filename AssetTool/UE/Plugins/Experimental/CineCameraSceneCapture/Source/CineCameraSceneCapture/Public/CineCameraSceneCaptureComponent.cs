namespace AssetTool
{
    [JsonAsset("CineCaptureComponent2D")]
    public class UCineCaptureComponent2D : USceneCaptureComponent2D
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}