namespace AssetTool
{
    [JsonAsset("ComponentElementEditorWorldInterface")]
    public class UComponentElementEditorWorldInterface : UComponentElementWorldInterface
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}