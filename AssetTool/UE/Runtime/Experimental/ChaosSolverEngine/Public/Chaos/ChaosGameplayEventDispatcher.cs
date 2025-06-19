namespace AssetTool
{
    [JsonAsset("ChaosGameplayEventDispatcher")]
    public class UChaosGameplayEventDispatcher : UChaosEventListenerComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}