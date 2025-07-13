namespace AssetTool
{
    [JsonAsset("AssetDefinition_SoundBase")]
    public class UAssetDefinition_SoundBase : UAssetDefinitionDefault
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}