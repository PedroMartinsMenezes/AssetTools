namespace AssetTool
{
    [JsonAsset("TriggerBase")]
    public class ATriggerBase : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}