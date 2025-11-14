namespace AssetTool
{
    [JsonAsset("LearningAgentsCritic")]
    public class ULearningAgentsCritic : ULearningAgentsManagerListener
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}