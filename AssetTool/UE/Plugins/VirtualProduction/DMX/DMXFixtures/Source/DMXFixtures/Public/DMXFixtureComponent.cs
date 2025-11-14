namespace AssetTool
{
    [JsonAsset("DMXFixtureComponent")]
    public class UDMXFixtureComponent : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}