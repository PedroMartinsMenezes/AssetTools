namespace AssetTool
{
    [JsonAsset("SoundNodeParamCrossFade")]
    public class USoundNodeParamCrossFade : USoundNodeDistanceCrossFade
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}