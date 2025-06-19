namespace AssetTool
{
    [JsonAsset("ForceFeedbackComponent")]
    public class UForceFeedbackComponent : USceneComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}