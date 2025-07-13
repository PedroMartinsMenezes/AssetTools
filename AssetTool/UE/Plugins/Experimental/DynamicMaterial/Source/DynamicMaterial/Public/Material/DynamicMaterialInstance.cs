namespace AssetTool
{
    [JsonAsset("DynamicMaterialInstance")]
    public class UDynamicMaterialInstance : UMaterialInstanceDynamic
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}