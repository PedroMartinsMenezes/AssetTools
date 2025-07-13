namespace AssetTool
{
    [JsonAsset("MusicTempometerComponent")]
    public class UMusicTempometerComponent : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}