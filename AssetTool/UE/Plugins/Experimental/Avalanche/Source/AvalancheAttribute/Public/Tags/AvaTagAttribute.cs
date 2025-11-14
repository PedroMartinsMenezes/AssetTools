namespace AssetTool
{
    [JsonAsset("AvaTagAttribute")]
    public class UAvaTagAttribute : UAvaTagAttributeBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}