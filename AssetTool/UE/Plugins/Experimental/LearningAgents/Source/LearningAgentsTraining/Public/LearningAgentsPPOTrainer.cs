namespace AssetTool
{
    [JsonAsset("LearningAgentsPPOTrainer")]
    public class ULearningAgentsPPOTrainer : ULearningAgentsManagerListener
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}