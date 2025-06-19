namespace AssetTool
{
    [JsonAsset("TriggerCapsule")]
    public class ATriggerCapsule : ATriggerBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}