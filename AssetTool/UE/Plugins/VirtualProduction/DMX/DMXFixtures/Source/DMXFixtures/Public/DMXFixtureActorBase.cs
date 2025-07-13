namespace AssetTool
{
    [JsonAsset("DMXFixtureActorBase")]
    public class ADMXFixtureActorBase : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}