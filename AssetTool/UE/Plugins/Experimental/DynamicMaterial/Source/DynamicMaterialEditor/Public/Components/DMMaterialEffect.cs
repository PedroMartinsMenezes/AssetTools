namespace AssetTool
{
    [JsonAsset("DMMaterialEffect")]
    public class UDMMaterialEffect : UDMMaterialComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}