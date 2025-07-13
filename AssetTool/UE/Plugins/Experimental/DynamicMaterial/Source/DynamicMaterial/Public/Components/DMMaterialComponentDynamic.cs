namespace AssetTool
{
    [JsonAsset("DMMaterialComponentDynamic")]
    public class UDMMaterialComponentDynamic : UDMMaterialComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}