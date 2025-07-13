namespace AssetTool
{
    [JsonAsset("DynamicMaterialModelBase")]
    public class UDynamicMaterialModelBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}