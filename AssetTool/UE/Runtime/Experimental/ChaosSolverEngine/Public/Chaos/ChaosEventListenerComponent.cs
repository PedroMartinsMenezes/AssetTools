namespace AssetTool
{
    [JsonAsset("ChaosEventListenerComponent")]
    public class UChaosEventListenerComponent : UActorComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}