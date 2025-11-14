namespace AssetTool
{
    [JsonAsset("ChaosGameplayEventDispatcher")]
    public class UChaosGameplayEventDispatcher : UChaosEventListenerComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}