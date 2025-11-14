namespace AssetTool
{
    [JsonAsset("HairCardGeneratorPluginSettings")]
    public class UHairCardGeneratorPluginSettings : UHairCardGenerationSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("HairCardGeneratorGroupSettings")]
    public class UHairCardGeneratorGroupSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}