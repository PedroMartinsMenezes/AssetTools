namespace AssetTool
{
    [JsonAsset("FloatingPawnMovement")]
    public class UFloatingPawnMovement : UPawnMovementComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}