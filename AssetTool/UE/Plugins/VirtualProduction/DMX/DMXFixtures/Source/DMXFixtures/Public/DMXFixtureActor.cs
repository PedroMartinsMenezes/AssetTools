namespace AssetTool
{
    [JsonAsset("DMXFixtureActor")]
    public class ADMXFixtureActor : ADMXFixtureActorBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}