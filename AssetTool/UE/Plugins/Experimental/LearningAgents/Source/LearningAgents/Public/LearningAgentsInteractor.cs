namespace AssetTool
{
    [JsonAsset("LearningAgentsInteractor")]
    public class ULearningAgentsInteractor : ULearningAgentsManagerListener
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}