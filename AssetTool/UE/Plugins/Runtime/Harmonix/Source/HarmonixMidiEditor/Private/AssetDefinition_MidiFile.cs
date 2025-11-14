namespace AssetTool
{
    [JsonAsset("AssetDefinition_MidiFile")]
    public class UAssetDefinition_MidiFile : UAssetDefinitionDefault
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}