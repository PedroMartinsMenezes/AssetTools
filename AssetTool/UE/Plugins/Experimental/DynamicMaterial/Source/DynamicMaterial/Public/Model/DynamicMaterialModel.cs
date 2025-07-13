namespace AssetTool
{
    [JsonAsset("DynamicMaterialModel")]
    public class UDynamicMaterialModel : UDynamicMaterialModelBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}