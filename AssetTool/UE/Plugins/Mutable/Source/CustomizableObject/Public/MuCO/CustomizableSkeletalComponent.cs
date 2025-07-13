namespace AssetTool
{
    [JsonAsset("CustomizableSkeletalComponent")]
    public class UCustomizableSkeletalComponent : USceneComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}