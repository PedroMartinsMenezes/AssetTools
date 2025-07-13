namespace AssetTool
{
    [JsonAsset("LearningAgentsPPOTrainer")]
    public class ULearningAgentsPPOTrainer : ULearningAgentsManagerListener
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}