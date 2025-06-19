namespace AssetTool
{
    [JsonAsset("SpectatorPawnMovement")]
    public class USpectatorPawnMovement : UFloatingPawnMovement
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}