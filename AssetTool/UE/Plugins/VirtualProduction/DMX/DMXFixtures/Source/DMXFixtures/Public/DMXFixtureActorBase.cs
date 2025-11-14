namespace AssetTool
{
    [JsonAsset("DMXFixtureActorBase")]
    public class ADMXFixtureActorBase : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}