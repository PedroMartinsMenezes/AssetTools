namespace AssetTool
{
    [JsonAsset("GameplayMessageProcessor")]
    public class UGameplayMessageProcessor : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}