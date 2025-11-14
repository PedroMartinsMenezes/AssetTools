namespace AssetTool
{
    [JsonAsset("LearningAgentsRecorder")]
    public class ULearningAgentsRecorder : ULearningAgentsManagerListener
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}