namespace AssetTool
{
    [JsonAsset("BTDecorator_ReachedMoveGoal")]
    public class UBTDecorator_ReachedMoveGoal : UBTDecorator
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}