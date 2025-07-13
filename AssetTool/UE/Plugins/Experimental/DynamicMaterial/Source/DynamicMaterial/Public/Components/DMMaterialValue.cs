namespace AssetTool
{
    [JsonAsset("DMMaterialValue")]
    public class UDMMaterialValue : UDMMaterialLinkedComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}