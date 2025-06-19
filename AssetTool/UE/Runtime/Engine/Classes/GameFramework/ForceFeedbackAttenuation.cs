namespace AssetTool
{
    [JsonAsset("ForceFeedbackAttenuation")]
    public class UForceFeedbackAttenuation : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}