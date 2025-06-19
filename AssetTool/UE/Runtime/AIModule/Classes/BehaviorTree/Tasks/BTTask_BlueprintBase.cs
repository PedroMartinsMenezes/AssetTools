namespace AssetTool
{
    [JsonAsset("BTTask_BlueprintBase")]
    public class UBTTask_BlueprintBase : UBTTaskNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}