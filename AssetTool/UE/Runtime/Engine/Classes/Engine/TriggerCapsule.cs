namespace AssetTool
{
    [JsonAsset("TriggerCapsule")]
    public class ATriggerCapsule : ATriggerBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}