namespace AssetTool
{
    [JsonAsset("LyraGamePhaseAbility")]
    public class ULyraGamePhaseAbility : ULyraGameplayAbility
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}