namespace AssetTool
{
    [JsonAsset("DMMaterialComponent")]
    public class UDMMaterialComponent : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}