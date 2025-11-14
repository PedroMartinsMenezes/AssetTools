namespace AssetTool
{
    [JsonAsset("AvaTagContainerAttribute")]
    public class UAvaTagContainerAttribute : UAvaTagAttributeBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}