namespace AssetTool
{
    [JsonAsset("CustomizableObjectSkeletalMesh")]
    public class UCustomizableObjectSkeletalMesh : USkeletalMesh
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}