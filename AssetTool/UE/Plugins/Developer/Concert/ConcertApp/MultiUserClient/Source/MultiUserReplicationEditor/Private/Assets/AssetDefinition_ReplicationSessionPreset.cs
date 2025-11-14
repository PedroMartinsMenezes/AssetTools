namespace AssetTool
{
    [JsonAsset("AssetDefinition_ReplicationSessionPreset")]
    public class UAssetDefinition_ReplicationSessionPreset : UAssetDefinitionDefault
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}