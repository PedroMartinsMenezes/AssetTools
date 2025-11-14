namespace AssetTool
{
    [JsonAsset("ForceFeedbackComponent")]
    public class UForceFeedbackComponent : USceneComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}