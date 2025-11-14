namespace AssetTool
{
    [JsonAsset("LyraGameplayCueManager")]
    public class ULyraGameplayCueManager : UGameplayCueManager
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}