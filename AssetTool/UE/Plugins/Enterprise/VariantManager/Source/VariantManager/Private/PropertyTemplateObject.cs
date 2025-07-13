namespace AssetTool
{
    [JsonAsset("PropertyTemplateObject")]
    public class UPropertyTemplateObject : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}