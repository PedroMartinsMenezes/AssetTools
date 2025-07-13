namespace AssetTool
{
    [JsonAsset("TransformPropertyFilter")]
    public class UTransformPropertyFilter : UPropertySelectorFilter
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}