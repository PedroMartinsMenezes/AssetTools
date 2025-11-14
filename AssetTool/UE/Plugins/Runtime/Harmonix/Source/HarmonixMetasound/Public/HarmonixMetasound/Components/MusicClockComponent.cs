namespace AssetTool
{
    [JsonAsset("MusicClockComponent")]
    public class UMusicClockComponent : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}