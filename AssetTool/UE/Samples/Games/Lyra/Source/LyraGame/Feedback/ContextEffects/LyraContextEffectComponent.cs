namespace AssetTool
{
    [JsonAsset("LyraContextEffectComponent")]
    public class ULyraContextEffectComponent : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}