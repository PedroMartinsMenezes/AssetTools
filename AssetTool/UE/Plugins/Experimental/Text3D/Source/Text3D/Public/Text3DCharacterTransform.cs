namespace AssetTool
{
    [JsonAsset("Text3DCharacterTransform")]
    public class UText3DCharacterTransform : USceneComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}