namespace AssetTool
{
    [JsonAsset("SoundSourceEffectFactory")]
    public class USoundSourceEffectFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SoundSourceEffectChainFactory")]
    public class USoundSourceEffectChainFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}