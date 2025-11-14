namespace AssetTool
{
    [JsonAsset("Text3DComponent")]
    public class UText3DComponent : USceneComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}