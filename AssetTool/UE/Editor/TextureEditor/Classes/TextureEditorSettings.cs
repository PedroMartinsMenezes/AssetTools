namespace AssetTool
{
    [JsonAsset("TextureEditorSettings")]
    public class UTextureEditorSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}