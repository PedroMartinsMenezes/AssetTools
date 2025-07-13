namespace AssetTool
{
    [JsonAsset("LearningAgentsPolicy")]
    public class ULearningAgentsPolicy : ULearningAgentsManagerListener
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}