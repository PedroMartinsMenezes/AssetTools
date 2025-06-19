namespace AssetTool
{
    [JsonAsset("MovementMixer")]
    public class UMovementMixer : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}