namespace AssetTool
{
    [JsonAsset("BTTask_PawnActionBase")]
    public class UBTTask_PawnActionBase : UBTTaskNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}