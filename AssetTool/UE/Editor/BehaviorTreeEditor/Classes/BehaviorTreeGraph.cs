namespace AssetTool
{
    [JsonAsset("BehaviorTreeGraph")]
    public class UBehaviorTreeGraph : UAIGraph
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}