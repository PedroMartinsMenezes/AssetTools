namespace AssetTool
{
    [JsonAsset("DMMaterialLayerObject")]
    public class UDMMaterialLayerObject : UDMMaterialComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}