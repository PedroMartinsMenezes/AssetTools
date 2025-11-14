namespace AssetTool
{
    [JsonAsset("BehaviorTreeComponent")]
    public class UBehaviorTreeComponent : UBrainComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}