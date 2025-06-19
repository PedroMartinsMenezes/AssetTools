namespace AssetTool
{
    [JsonAsset("BehaviorTreeComponent")]
    public class UBehaviorTreeComponent : UBrainComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}