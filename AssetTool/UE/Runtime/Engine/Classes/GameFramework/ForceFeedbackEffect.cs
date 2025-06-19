namespace AssetTool
{
    [JsonAsset("ForceFeedbackEffect")]
    public class UForceFeedbackEffect : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}