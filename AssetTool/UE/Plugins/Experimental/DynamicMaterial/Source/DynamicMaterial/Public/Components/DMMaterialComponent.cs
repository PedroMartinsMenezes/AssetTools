namespace AssetTool
{
    [JsonAsset("DMMaterialComponent")]
    public class UDMMaterialComponent : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}