namespace AssetTool
{
    [JsonAsset("TransformPropertyFilter")]
    public class UTransformPropertyFilter : UPropertySelectorFilter
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}