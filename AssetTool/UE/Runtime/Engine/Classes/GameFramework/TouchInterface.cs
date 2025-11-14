namespace AssetTool
{
    [JsonAsset("TouchInterface")]
    public class UTouchInterface : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}