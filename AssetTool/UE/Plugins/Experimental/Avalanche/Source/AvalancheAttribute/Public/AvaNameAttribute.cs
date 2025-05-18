namespace AssetTool
{
    [JsonAsset("AvaNameAttribute")]
    public class UAvaNameAttribute : UAvaAttribute
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}