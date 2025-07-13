namespace AssetTool
{
    [JsonAsset("BaseMovementComponent")]
    public class UBaseMovementComponent : UNetworkPredictionComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}