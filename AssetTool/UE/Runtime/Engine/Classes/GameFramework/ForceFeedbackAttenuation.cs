namespace AssetTool
{
    [JsonAsset("ForceFeedbackAttenuation")]
    public class UForceFeedbackAttenuation : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}