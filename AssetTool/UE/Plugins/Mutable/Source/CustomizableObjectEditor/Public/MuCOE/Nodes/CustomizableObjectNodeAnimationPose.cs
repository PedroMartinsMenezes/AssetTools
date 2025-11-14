namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodeAnimationPose")]
    public class UCustomizableObjectNodeAnimationPose : UCustomizableObjectNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}