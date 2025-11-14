namespace AssetTool
{
    [JsonAsset("SoundNodeParamCrossFade")]
    public class USoundNodeParamCrossFade : USoundNodeDistanceCrossFade
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}