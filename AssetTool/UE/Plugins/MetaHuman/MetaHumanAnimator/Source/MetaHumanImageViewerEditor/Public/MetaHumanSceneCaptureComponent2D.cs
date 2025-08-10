namespace AssetTool
{
    [JsonAsset("MetaHumanSceneCaptureComponent2D")]
    public class UMetaHumanSceneCaptureComponent2D : USceneCaptureComponent2D
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}