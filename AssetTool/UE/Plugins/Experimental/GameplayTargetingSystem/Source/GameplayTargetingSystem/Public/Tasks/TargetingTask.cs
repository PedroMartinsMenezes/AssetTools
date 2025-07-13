namespace AssetTool
{
    [JsonAsset("TargetingTask")]
    public class UTargetingTask : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}