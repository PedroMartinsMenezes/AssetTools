namespace AssetTool
{
    [JsonAsset("DMMaterialLinkedComponent")]
    public class UDMMaterialLinkedComponent : UDMMaterialComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}