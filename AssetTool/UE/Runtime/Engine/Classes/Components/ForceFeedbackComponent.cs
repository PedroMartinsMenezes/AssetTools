namespace AssetTool
{
    [JsonAsset("ForceFeedbackComponent")]
    public class UForceFeedbackComponent : USceneComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}