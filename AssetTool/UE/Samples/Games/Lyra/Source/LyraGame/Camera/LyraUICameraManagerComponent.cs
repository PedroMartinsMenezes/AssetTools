namespace AssetTool
{
    [JsonAsset("LyraUICameraManagerComponent")]
    public class ULyraUICameraManagerComponent : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}