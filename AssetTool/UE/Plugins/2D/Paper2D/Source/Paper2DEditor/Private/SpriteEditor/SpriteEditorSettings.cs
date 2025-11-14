namespace AssetTool
{
    [JsonAsset("SpriteEditorSettings")]
    public class USpriteEditorSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}