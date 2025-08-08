namespace AssetTool
{
    [JsonAsset("ChaosMovementMode")]
    public class UChaosMovementMode : UBaseMovementMode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}