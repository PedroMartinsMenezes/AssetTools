namespace AssetTool
{
    [JsonAsset("RotatingMovementComponent")]
    public class URotatingMovementComponent : UMovementComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}