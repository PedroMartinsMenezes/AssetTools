namespace AssetTool
{
    [JsonAsset("DMMaterialValueDynamic")]
    public class UDMMaterialValueDynamic : UDMMaterialComponentDynamic
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}