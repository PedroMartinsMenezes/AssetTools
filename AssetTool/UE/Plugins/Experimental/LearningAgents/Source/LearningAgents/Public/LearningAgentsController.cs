namespace AssetTool
{
    [JsonAsset("LearningAgentsController")]
    public class ULearningAgentsController : ULearningAgentsManagerListener
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}