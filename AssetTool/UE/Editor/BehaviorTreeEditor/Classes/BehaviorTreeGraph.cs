namespace AssetTool
{
    [JsonAsset("BehaviorTreeGraph")]
    public class UBehaviorTreeGraph : UAIGraph
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}