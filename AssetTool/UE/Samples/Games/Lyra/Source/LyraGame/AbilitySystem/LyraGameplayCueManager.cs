namespace AssetTool
{
    [JsonAsset("LyraGameplayCueManager")]
    public class ULyraGameplayCueManager : UGameplayCueManager
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}