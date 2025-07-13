namespace AssetTool
{
    [JsonAsset("SoundModulationClassTemplate")]
    public class USoundModulationClassTemplate : UPluginClassTemplate
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SoundModulationGeneratorClassTemplate")]
    public class USoundModulationGeneratorClassTemplate : USoundModulationClassTemplate
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}