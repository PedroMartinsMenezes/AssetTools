namespace AssetTool
{
    [JsonAsset("PropertyValueMaterial")]
    public class UPropertyValueMaterial : UPropertyValue
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}