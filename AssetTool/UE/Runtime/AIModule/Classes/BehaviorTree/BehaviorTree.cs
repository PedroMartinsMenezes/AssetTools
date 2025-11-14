namespace AssetTool
{
    [JsonAsset("BehaviorTree")]
    public class UBehaviorTree : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}