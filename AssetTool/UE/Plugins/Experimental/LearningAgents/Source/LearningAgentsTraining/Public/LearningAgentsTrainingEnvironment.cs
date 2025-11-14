namespace AssetTool
{
    [JsonAsset("LearningAgentsTrainingEnvironment")]
    public class ULearningAgentsTrainingEnvironment : ULearningAgentsManagerListener
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}