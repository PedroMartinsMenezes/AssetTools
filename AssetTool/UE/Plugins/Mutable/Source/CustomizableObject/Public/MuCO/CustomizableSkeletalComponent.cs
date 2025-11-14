namespace AssetTool
{
    [JsonAsset("CustomizableSkeletalComponent")]
    public class UCustomizableSkeletalComponent : USceneComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}