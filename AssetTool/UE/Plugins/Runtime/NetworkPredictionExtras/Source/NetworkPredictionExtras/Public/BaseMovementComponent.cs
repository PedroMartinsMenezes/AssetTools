namespace AssetTool
{
    [JsonAsset("BaseMovementComponent")]
    public class UBaseMovementComponent : UNetworkPredictionComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}