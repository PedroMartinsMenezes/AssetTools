namespace AssetTool
{
    [TransferableStruct("TG_Material")]
    public class FTG_Material : ITransferable
    {
        public FSoftObjectPath AssetPath;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref AssetPath);
            return this;
        }
    }
}
