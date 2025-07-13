namespace AssetTool
{
    [JsonAsset("BlackboardDataFactory")]
    public class UBlackboardDataFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}