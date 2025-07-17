namespace AssetTool
{
    [JsonAsset("LyraBotCheats")]
    public class ULyraBotCheats : UCheatManagerExtension
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}