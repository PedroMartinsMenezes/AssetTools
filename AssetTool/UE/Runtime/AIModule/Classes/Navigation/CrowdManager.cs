namespace AssetTool
{
    [JsonAsset("CrowdManager")]
    public class UCrowdManager : UCrowdManagerBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}