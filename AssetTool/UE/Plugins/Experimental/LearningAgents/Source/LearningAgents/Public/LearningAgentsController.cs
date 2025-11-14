namespace AssetTool
{
    [JsonAsset("LearningAgentsController")]
    public class ULearningAgentsController : ULearningAgentsManagerListener
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}