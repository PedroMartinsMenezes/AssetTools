namespace AssetTool
{
    [JsonAsset("LyraUICameraManagerComponent")]
    public class ULyraUICameraManagerComponent : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}