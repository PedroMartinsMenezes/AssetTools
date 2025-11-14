namespace AssetTool
{
    [JsonAsset("ChaosEventListenerComponent")]
    public class UChaosEventListenerComponent : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}