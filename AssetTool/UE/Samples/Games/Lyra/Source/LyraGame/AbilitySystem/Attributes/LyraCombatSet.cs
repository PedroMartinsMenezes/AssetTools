namespace AssetTool
{
    [JsonAsset("LyraCombatSet")]
    public class ULyraCombatSet : ULyraAttributeSet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}