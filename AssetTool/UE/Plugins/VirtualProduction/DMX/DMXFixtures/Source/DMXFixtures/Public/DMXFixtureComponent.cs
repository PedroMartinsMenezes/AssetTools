namespace AssetTool
{
    [JsonAsset("DMXFixtureComponent")]
    public class UDMXFixtureComponent : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}