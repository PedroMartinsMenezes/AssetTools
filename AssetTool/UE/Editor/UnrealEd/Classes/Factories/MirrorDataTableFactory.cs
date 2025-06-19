namespace AssetTool
{
    [JsonAsset("MirrorTableFindReplaceExpressions")]
    public class UMirrorTableFindReplaceExpressions : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MirrorDataTableFactory")]
    public class UMirrorDataTableFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}