namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodeAnimationPose")]
    public class UCustomizableObjectNodeAnimationPose : UCustomizableObjectNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}