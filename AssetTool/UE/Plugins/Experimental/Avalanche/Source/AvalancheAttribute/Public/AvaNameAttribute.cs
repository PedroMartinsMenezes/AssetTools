namespace AssetTool
{
    [JsonAsset("AvaNameAttribute")]
    public class UAvaNameAttribute : UAvaAttribute
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}