namespace AssetTool
{
    [JsonAsset("SoundNodeParamCrossFade")]
    public class USoundNodeParamCrossFade : USoundNodeDistanceCrossFade
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}