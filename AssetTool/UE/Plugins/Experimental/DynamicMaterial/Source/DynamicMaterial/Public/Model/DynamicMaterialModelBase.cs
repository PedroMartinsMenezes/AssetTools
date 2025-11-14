namespace AssetTool
{
    [JsonAsset("DynamicMaterialModelBase")]
    public class UDynamicMaterialModelBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}