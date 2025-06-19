namespace AssetTool
{
    [JsonAsset("Text3DCharacterTransform")]
    public class UText3DCharacterTransform : USceneComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}