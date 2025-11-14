namespace AssetTool
{
    [JsonAsset("ChaosMovementMode")]
    public class UChaosMovementMode : UBaseMovementMode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}