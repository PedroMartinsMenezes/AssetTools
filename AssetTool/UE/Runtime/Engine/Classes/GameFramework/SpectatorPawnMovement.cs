namespace AssetTool
{
    [JsonAsset("SpectatorPawnMovement")]
    public class USpectatorPawnMovement : UFloatingPawnMovement
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}