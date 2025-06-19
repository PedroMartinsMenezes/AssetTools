namespace AssetTool
{
    [JsonAsset("PropertyBagMissingObject")]
    public class UPropertyBagMissingObject : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PropertyBag")]
    public class UPropertyBag : UScriptStruct
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}