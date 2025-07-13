namespace AssetTool
{
    [JsonAsset("AssetDefinition_SoundConcurrency")]
    public class UAssetDefinition_SoundConcurrency : UAssetDefinitionDefault
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}