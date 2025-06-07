namespace AssetTool
{
    [JsonAsset("ChaosGameplayEventDispatcher")]
    public class UChaosGameplayEventDispatcher : UChaosEventListenerComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}