namespace AssetTool
{
    [JsonAsset("LyraCombatSet")]
    public class ULyraCombatSet : ULyraAttributeSet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}