namespace AssetTool
{
    [JsonAsset("ChaosEventListenerComponent")]
    public class UChaosEventListenerComponent : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}