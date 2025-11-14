namespace AssetTool
{
    [JsonAsset("LyraPawnExtensionComponent")]
    public class ULyraPawnExtensionComponent : UPawnComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}