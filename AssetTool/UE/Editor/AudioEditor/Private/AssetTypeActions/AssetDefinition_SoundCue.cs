namespace AssetTool
{
    [JsonAsset("AssetDefinition_SoundCue")]
    public class UAssetDefinition_SoundCue : UAssetDefinition_SoundBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}