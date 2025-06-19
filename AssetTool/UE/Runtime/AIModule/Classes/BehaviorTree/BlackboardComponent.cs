namespace AssetTool
{
    [JsonAsset("BlackboardComponent")]
    public class UBlackboardComponent : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}