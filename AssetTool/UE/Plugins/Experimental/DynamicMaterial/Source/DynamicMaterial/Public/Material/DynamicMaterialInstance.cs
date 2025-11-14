namespace AssetTool
{
    [JsonAsset("DynamicMaterialInstance")]
    public class UDynamicMaterialInstance : UMaterialInstanceDynamic
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}