namespace AssetTool
{
    [JsonAsset("LyraPawnExtensionComponent")]
    public class ULyraPawnExtensionComponent : UPawnComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}