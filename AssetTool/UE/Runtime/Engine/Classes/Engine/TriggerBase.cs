namespace AssetTool
{
    [JsonAsset("TriggerBase")]
    public class ATriggerBase : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}