namespace AssetTool
{
    [JsonAsset("SVGReimportFactory")]
    public class USVGReimportFactory : USVGFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}