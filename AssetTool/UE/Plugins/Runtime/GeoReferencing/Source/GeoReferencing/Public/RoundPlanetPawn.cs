namespace AssetTool
{
    [JsonAsset("RoundPlanetPawn")]
    public class ARoundPlanetPawn : ADefaultPawn
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}