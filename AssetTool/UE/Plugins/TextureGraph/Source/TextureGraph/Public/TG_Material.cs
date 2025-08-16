namespace AssetTool
{
    [TransferibleStruct("TG_Material")]
    public class FTG_Material : ITransferible
    {
        public FSoftObjectPath AssetPath;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref AssetPath);
            return this;
        }
    }
}
