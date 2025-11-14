namespace AssetTool
{
    [JsonAsset("MusicTempometerComponent")]
    public class UMusicTempometerComponent : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}