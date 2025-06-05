namespace AssetTool
{
    [JsonAsset("AvaTagAttributeBase")]
    public class UAvaTagAttributeBase : UAvaAttribute
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}