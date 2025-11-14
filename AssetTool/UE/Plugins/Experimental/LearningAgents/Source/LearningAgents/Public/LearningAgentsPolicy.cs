namespace AssetTool
{
    [JsonAsset("LearningAgentsPolicy")]
    public class ULearningAgentsPolicy : ULearningAgentsManagerListener
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}