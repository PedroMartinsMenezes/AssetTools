namespace AssetTool
{
    [JsonAsset("SpectatorPawn")]
    public class ASpectatorPawn : ADefaultPawn
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}