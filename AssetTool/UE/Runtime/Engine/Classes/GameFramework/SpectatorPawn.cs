namespace AssetTool
{
    [JsonAsset("SpectatorPawn")]
    public class ASpectatorPawn : ADefaultPawn
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}