namespace AssetTool
{
    [JsonAsset("ComponentElementEditorWorldInterface")]
    public class UComponentElementEditorWorldInterface : UComponentElementWorldInterface
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}