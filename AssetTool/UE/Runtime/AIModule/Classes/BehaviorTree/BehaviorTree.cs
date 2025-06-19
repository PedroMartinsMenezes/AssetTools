namespace AssetTool
{
    [JsonAsset("BehaviorTree")]
    public class UBehaviorTree : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}