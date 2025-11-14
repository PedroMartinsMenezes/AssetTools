namespace AssetTool
{
    [JsonAsset("SpectatorPawnMovement")]
    public class USpectatorPawnMovement : UFloatingPawnMovement
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}