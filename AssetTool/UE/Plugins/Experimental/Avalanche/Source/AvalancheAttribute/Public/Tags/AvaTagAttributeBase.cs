namespace AssetTool
{
    [JsonAsset("AvaTagAttributeBase")]
    public class UAvaTagAttributeBase : UAvaAttribute
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}