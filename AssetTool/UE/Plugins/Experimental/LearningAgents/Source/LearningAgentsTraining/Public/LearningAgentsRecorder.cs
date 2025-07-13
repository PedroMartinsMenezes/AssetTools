namespace AssetTool
{
    [JsonAsset("LearningAgentsRecorder")]
    public class ULearningAgentsRecorder : ULearningAgentsManagerListener
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}