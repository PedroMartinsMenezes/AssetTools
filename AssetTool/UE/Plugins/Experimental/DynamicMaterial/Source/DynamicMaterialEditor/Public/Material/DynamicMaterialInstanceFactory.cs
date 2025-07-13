namespace AssetTool
{
    [JsonAsset("DynamicMaterialInstanceFactory")]
    public class UDynamicMaterialInstanceFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}