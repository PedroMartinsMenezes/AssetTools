namespace AssetTool
{
    [JsonAsset("TargetingSortTask_Base")]
    public class UTargetingSortTask_Base : UTargetingTask
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}