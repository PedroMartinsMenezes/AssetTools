namespace AssetTool
{
    [JsonAsset("TriggerBox")]
    public class ATriggerBox : ATriggerBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}