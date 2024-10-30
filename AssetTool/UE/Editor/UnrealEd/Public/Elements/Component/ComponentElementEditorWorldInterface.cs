namespace AssetTool
{
    [JsonAsset("ComponentElementEditorWorldInterface")]
    public class UComponentElementEditorWorldInterface : UComponentElementWorldInterface
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}