namespace AssetTool
{
    [JsonAsset("CustomizableObjectSkeletalMesh")]
    public class UCustomizableObjectSkeletalMesh : USkeletalMesh
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}