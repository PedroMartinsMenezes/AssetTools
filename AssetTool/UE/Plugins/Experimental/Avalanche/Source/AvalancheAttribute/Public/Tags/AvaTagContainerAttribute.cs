namespace AssetTool
{
    [JsonAsset("AvaTagContainerAttribute")]
    public class UAvaTagContainerAttribute : UAvaTagAttributeBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}