namespace AssetTool
{
    [JsonAsset("PropertyValueMaterial")]
    public class UPropertyValueMaterial : UPropertyValue
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}