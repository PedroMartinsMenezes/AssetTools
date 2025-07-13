namespace AssetTool
{
    [JsonAsset("DMMaterialProperty")]
    public class UDMMaterialProperty : UDMMaterialComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}