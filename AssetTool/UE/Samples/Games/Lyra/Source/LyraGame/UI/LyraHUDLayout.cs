namespace AssetTool
{
    [JsonAsset("LyraHUDLayout")]
    public class ULyraHUDLayout : ULyraActivatableWidget
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}