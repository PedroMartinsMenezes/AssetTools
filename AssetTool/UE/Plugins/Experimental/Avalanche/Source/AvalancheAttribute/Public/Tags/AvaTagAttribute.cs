namespace AssetTool
{
    [JsonAsset("AvaTagAttribute")]
    public class UAvaTagAttribute : UAvaTagAttributeBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}