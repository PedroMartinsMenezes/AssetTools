namespace AssetTool
{
    [JsonAsset("LearningAgentsTrainingEnvironment")]
    public class ULearningAgentsTrainingEnvironment : ULearningAgentsManagerListener
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}