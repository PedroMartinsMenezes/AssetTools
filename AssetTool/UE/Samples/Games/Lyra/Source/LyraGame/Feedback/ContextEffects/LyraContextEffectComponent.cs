namespace AssetTool
{
    [JsonAsset("LyraContextEffectComponent")]
    public class ULyraContextEffectComponent : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}