namespace AssetTool
{
    [JsonAsset("BehaviorTreeComponent")]
    public class UBehaviorTreeComponent : UBrainComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}