namespace AssetTool
{
    [JsonAsset("BTTask_GameplayTaskBase")]
    public class UBTTask_GameplayTaskBase : UBTTaskNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}