namespace AssetTool
{
    [JsonAsset("DMXFixtureActorMatrix")]
    public class ADMXFixtureActorMatrix : ADMXFixtureActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}