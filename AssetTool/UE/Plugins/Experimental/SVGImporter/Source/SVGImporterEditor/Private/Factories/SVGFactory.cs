namespace AssetTool
{
    [JsonAsset("SVGFactory")]
    public class USVGFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}