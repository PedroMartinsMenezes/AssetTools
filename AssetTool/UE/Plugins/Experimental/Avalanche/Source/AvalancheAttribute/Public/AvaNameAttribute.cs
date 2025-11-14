namespace AssetTool
{
    [JsonAsset("AvaNameAttribute")]
    public class UAvaNameAttribute : UAvaAttribute
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}