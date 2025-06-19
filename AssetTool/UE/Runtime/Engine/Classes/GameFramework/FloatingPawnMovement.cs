namespace AssetTool
{
    [JsonAsset("FloatingPawnMovement")]
    public class UFloatingPawnMovement : UPawnMovementComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}