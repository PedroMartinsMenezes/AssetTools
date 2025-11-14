namespace AssetTool
{
    [JsonAsset("DynamicMaterialModel")]
    public class UDynamicMaterialModel : UDynamicMaterialModelBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}