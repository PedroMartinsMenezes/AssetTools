namespace AssetTool
{
    [JsonAsset("GameplayMessageProcessor")]
    public class UGameplayMessageProcessor : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}