namespace AssetTool
{
    [JsonAsset("AvaTagAttributeBase")]
    public class UAvaTagAttributeBase : UAvaAttribute
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}