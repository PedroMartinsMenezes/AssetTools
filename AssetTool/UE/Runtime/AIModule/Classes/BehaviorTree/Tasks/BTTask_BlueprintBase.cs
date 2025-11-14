namespace AssetTool
{
    [JsonAsset("BTTask_BlueprintBase")]
    public class UBTTask_BlueprintBase : UBTTaskNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}