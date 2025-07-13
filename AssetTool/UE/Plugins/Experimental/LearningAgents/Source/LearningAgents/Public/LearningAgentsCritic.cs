namespace AssetTool
{
    [JsonAsset("LearningAgentsCritic")]
    public class ULearningAgentsCritic : ULearningAgentsManagerListener
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}