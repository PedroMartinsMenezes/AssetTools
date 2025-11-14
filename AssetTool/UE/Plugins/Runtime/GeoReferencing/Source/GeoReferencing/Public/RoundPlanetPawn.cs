namespace AssetTool
{
    [JsonAsset("RoundPlanetPawn")]
    public class ARoundPlanetPawn : ADefaultPawn
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}