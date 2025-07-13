namespace AssetTool
{
    [JsonAsset("LearningAgentsImitationTrainer")]
    public class ULearningAgentsImitationTrainer : ULearningAgentsManagerListener
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}