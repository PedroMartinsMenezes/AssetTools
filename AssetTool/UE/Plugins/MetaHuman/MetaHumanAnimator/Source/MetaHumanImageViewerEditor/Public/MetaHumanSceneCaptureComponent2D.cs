namespace AssetTool
{
    [JsonAsset("MetaHumanSceneCaptureComponent2D")]
    public class UMetaHumanSceneCaptureComponent2D : USceneCaptureComponent2D
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}