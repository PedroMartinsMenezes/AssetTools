namespace AssetTool
{
    [JsonAsset("SpriteEditorSettings")]
    public class USpriteEditorSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}