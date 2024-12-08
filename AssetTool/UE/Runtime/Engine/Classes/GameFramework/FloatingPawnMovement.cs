namespace AssetTool
{
    [JsonAsset("FloatingPawnMovement")]
    public class UFloatingPawnMovement : UPawnMovementComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}