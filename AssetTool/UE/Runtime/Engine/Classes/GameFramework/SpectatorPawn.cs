namespace AssetTool
{
    [JsonAsset("SpectatorPawn")]
    public class ASpectatorPawn : ADefaultPawn
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}