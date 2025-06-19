namespace AssetTool
{
    [JsonAsset("BTTask_BlackboardBase")]
    public class UBTTask_BlackboardBase : UBTTaskNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}