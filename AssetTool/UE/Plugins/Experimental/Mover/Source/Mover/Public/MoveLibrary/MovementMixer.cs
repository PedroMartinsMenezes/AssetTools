namespace AssetTool
{
    [JsonAsset("MovementMixer")]
    public class UMovementMixer : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}