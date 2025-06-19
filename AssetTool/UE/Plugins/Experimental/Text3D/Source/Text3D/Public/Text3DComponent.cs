namespace AssetTool
{
    [JsonAsset("Text3DComponent")]
    public class UText3DComponent : USceneComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}