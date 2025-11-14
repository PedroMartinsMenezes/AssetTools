namespace AssetTool
{
    [JsonAsset("DMXFixtureActorMatrix")]
    public class ADMXFixtureActorMatrix : ADMXFixtureActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}