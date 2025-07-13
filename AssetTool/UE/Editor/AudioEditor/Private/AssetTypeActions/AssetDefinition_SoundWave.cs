namespace AssetTool
{
    [JsonAsset("AssetDefinition_SoundWave")]
    public class UAssetDefinition_SoundWave : UAssetDefinition_SoundBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}