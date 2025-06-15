namespace AssetTool
{
    [JsonAsset("AITask")]
    public class UAITask : UGameplayTask
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}