namespace AssetTool
{
    [JsonAsset("DMXFixtureActor")]
    public class ADMXFixtureActor : ADMXFixtureActorBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}