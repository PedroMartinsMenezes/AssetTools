namespace AssetTool
{
    [JsonAsset("LearningAgentsInteractor")]
    public class ULearningAgentsInteractor : ULearningAgentsManagerListener
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}