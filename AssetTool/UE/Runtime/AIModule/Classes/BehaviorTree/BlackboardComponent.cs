namespace AssetTool
{
    [JsonAsset("BlackboardComponent")]
    public class UBlackboardComponent : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}