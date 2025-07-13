namespace AssetTool
{
    [JsonAsset("MotoSynthPresetFactory")]
    public class UMotoSynthPresetFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MotoSynthSourceFactory")]
    public class UMotoSynthSourceFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}