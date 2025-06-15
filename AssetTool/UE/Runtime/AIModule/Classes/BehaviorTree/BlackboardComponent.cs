namespace AssetTool
{
    [JsonAsset("BlackboardComponent")]
    public class UBlackboardComponent : UActorComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}