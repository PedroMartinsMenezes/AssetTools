namespace AssetTool
{
    [JsonAsset("BTTask_BlackboardBase")]
    public class UBTTask_BlackboardBase : UBTTaskNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}