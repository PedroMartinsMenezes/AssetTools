namespace AssetTool
{
    [JsonAsset("TriggerBox")]
    public class ATriggerBox : ATriggerBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}