namespace AssetTool
{
    [JsonAsset("ForceFeedbackEffectFactory")]
    public class UForceFeedbackEffectFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}