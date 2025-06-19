namespace AssetTool
{
    [JsonAsset("AITask")]
    public class UAITask : UGameplayTask
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}