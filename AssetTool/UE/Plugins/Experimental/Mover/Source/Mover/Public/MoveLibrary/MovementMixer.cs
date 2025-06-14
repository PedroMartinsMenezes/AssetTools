namespace AssetTool
{
    [JsonAsset("MovementMixer")]
    public class UMovementMixer : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}