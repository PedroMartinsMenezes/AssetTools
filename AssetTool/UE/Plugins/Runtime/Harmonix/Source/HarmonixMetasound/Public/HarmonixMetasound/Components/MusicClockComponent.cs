namespace AssetTool
{
    [JsonAsset("MusicClockComponent")]
    public class UMusicClockComponent : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}