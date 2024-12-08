namespace AssetTool
{
    [JsonAsset("TriggerBase")]
    public class ATriggerBase : AActor
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}