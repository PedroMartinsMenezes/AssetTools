namespace AssetTool
{
    [JsonAsset("AvaAttribute")]
    public class UAvaAttribute : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}