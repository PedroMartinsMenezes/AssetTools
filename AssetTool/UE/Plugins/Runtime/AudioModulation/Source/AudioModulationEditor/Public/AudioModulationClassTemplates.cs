namespace AssetTool
{
    [JsonAsset("SoundModulationClassTemplate")]
    public class USoundModulationClassTemplate : UPluginClassTemplate
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SoundModulationGeneratorClassTemplate")]
    public class USoundModulationGeneratorClassTemplate : USoundModulationClassTemplate
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}