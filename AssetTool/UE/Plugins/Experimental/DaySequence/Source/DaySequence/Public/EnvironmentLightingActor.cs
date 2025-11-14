namespace AssetTool
{
    [JsonAsset("EnvironmentLightingActor")]
    public class AEnvironmentLightingActor : ADaySequenceProvider
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}